using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaTran_Server
{
    class Program
    {        
          static void Main(string[] args)
          {
            TcpListener serverSocket = new TcpListener(IPAddress.Any ,9050);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            serverSocket.Start();
            Console.WriteLine(" >> " + "Bat dau server");

            counter = 0;
            while (true)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(" >> " + "Client thu : " + Convert.ToString(counter) + " da ket noi vao!");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, Convert.ToString(counter));                
            }
            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> " + "exit");
            Console.ReadLine();
        }
    }

    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        NetworkStream networkStream;       

        int[,] mt1;
        int[,] mt2;
        int[,] mtkq;

        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(giaimatran);
            ctThread.Start();
        }

        private void FromByteArray(byte[] input)
        {
            using (var stream = new MemoryStream(input))
            using (var reader = new BinaryReader(stream, Encoding.UTF8))
            {
                var rows = reader.ReadInt32();
                var column = reader.ReadInt32();
                mt1 = new int[rows, column];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        mt1[i, j] = reader.ReadInt32();                        
                    }
                }
            }
        }

        private void FromByteArray2(byte[] input)
        {
            using (var stream = new MemoryStream(input))
            using (var reader = new BinaryReader(stream, Encoding.UTF8))
            {
                var rows = reader.ReadInt32();
                var column = reader.ReadInt32();
                mt2 = new int[rows, column];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        mt2[i, j] = reader.ReadInt32();
                    }
                }
            }
        }

        private void Giai()
        {
            MaTran matran1 = new MaTran(mt1);
            MaTran matran2 = new MaTran(mt2);
            MaTran giaimatran = matran1 * matran2;
            AddVaoKetQua(giaimatran);
        }

        private byte[] MatrixToBytes(int[,] matrix)
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.UTF8))
            {
                var rows = mtkq.GetLength(0);
                var column = mtkq.GetLength(1);
                writer.Write(rows);
                writer.Write(column);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        writer.Write(mtkq[i, j]);
                    }
                }
                writer.Flush();
                return stream.ToArray();
            }
        }

        private void AddVaoKetQua(MaTran table)
        {
            mtkq = new int[table.Rows, table.Columns];
            for (int i = 0; i < table.Rows; i++)
            {               
                for (int j = 0; j < table.Columns; j++)
                {
                    mtkq[i, j] = table[i, j];                   
                }                
            }
        }

        
        private void giaimatran()
        {                        
            byte[] bytesFrom = new byte[1024];   
            byte[] sendBytes = null;                  

            while ((true))
            {
                try
                {                                 
                    networkStream = clientSocket.GetStream();                   
                    if (networkStream != null)
                    {                       
                        networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                        Console.WriteLine(" >> Client " + clNo + " vua gui noi dung cua ma tran 1 ");                   
                        FromByteArray(bytesFrom);
                        networkStream.Flush();                        

                        while ((true))
                        {
                            try
                            {
                                networkStream = clientSocket.GetStream();
                                if (networkStream != null)
                                {
                                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                                    Console.WriteLine(" >> Client " + clNo + "  vua gui noi dung cua ma tran 2 ");
                                    FromByteArray2(bytesFrom);
                                    networkStream.Flush();                                    
                                    
                                    Giai();                                    
                                    sendBytes = MatrixToBytes(mtkq);                                                                
                                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                                    networkStream.Flush();
                                    Console.WriteLine(" >> Da gui ket qua den client " + clNo + "");
                                }
                            }
                            catch
                            {

                            }
                        }
                       
                    }                    
                }
                catch 
                {
                   
                }
            }
            networkStream.Close();
            clientSocket.Close();
            Console.WriteLine(" >> Exit");
        }
    }
}
