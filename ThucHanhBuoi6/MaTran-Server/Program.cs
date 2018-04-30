﻿using System;
using System.Collections.Generic;
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

        int nhan;
        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }
        private void doChat()
        {
            bool run = true;
            int requestCount = 0;
            byte[] bytesFrom = new byte[1024];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;                    
                    networkStream = clientSocket.GetStream();
                    if (networkStream != null)
                    {
                        nhan = networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                        dataFromClient = Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine(" >> " + "client thu - " + clNo + " vua gui " + dataFromClient);
                        rCount = Convert.ToString(requestCount);
                        serverResponse = "Server to client(" + clNo + ") " + rCount;
                        sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();                       
                        Console.WriteLine(" >> " + serverResponse);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {                                    

                }
            }
            networkStream.Close();
            clientSocket.Close();
            Console.WriteLine(" >> Exit");
        }
    }
}
