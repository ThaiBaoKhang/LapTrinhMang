using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClientToServer
{
    class Client
    {
        Socket clientSock;
        public void KetNoiDenServer()
        {
            try
            {
                Console.WriteLine("Ban se nhan duoc file tu server neu server dang online! ");
                IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                clientSock = new Socket(ipAddress[0].AddressFamily, SocketType.Stream, ProtocolType.IP);
                clientSock.Connect(ipEnd);
                NhanFileTuServer();                               
            }
            catch
            {
                Console.WriteLine("Server dang offline hoac loi ket noi !");
            }           
        }

        public void NhanFileTuServer()
        {
            try
            {
                byte[] clientData = new byte[1024 * 5000];
                string thumucnhan = System.Reflection.Assembly.GetExecutingAssembly().Location; // thư mục nhận = thư mục để file exe
                string receivedPath = thumucnhan;               
                int receivedBytesLen = clientSock.Receive(clientData);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);
                Console.WriteLine("May khach ket noi den : {0} va bat dau nhan file {1} ", clientSock.RemoteEndPoint, fileName);
                BinaryWriter bWrite = new BinaryWriter(File.Open(fileName, FileMode.Append)); ;
                bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
                Console.WriteLine("Da nhan file: {0} ", fileName);
                bWrite.Close();
                clientSock.Close();
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine("Nhan file xuat hien loi! " + ex.Message);
            }           
        }
    }
}
