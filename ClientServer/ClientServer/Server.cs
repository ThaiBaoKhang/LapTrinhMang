using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerClient
{
    class Server
    {
        string[] tenfile;
        Socket client;
        int input;
        public void KetNoiClient()
        {
            try
            {
                Console.WriteLine("Ung dung nay co the gui file cho may khach!");
                LayTenFile();
                XuatTenFile();
                NhapFileChon();
                Console.WriteLine("Client nao ket noi den may chu se nhan duoc file gui");
                IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                Socket sock = new Socket(ipAddress[0].AddressFamily, SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);
                sock.Listen(100);
                client = sock.Accept();
                Console.WriteLine("Co client ket noi den!");
                GuiFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }        
        }        

        public void LayTenFile()
        {
            string thumuc = @"C:\Test";
            string[] dinhdangvanban = { "doc","docx","xls","xlsx","pdf","pps","ppsx","ppt","pptx","txt"};
            tenfile = Directory.GetFiles(thumuc, "*.*").Where(f => dinhdangvanban.Contains(f.Split('.').Last().ToLower())).ToArray();            
        }

        public void XuatTenFile()
        {            
            Console.WriteLine("Danh sach nhung file co trong thu muc : ");
            Console.WriteLine();
            for (int i = 0; i < tenfile.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + Path.GetFileName(tenfile[i]) + " ");
            }            
        }
        
        public void NhapFileChon()
        {                   
            Console.WriteLine();
            Console.Write("- Nhap vao so thu tu tuong duong voi ten file ma ban muon gui: ");
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input < 0 || input > tenfile.Length)
                {
                    Console.WriteLine("Khong co so thu tu nay ! de nghi nhap lai ");
                    return;
                }                
            }
            catch
            {
                Console.WriteLine("Loi nhap sai ! khong duoc nhap ki tu ");
            }
        }
        
        public void GuiFile()
        {
            try
            {
                string fileName = ""; //Tên file
                string filePath = @"C:\Test\"; //Vị trí thư mục     
                Console.WriteLine();
                Console.WriteLine("Ban chon so thu tu {0} voi ten file {1} duoc gui di", input, Path.GetFileName(tenfile[input - 1]));
                fileName = Path.GetFileName(tenfile[input - 1]);
                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                byte[] fileData = File.ReadAllBytes(filePath + fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                client.Send(clientData);
                Console.WriteLine("Da gui file :{0} ", fileName);
                client.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ket noi! khong gui duoc file " + ex.Message);
            }
        }
        
    }
}
