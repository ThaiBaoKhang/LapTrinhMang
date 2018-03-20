using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OanTuXi_Server
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Socket newsock;
            IPEndPoint ipep;          
            byte[] data = new byte[1024];
            IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");        
            newsock = new Socket(ipAddress[1].AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(ipAddress[1], 9050);
            newsock.Bind(ipep);
            EndPoint ep = ipep;
            Console.Write("IP = " + ipAddress[1]);
            Console.WriteLine("Server dang mo!");
           
            byte[] nhanthongtinclient = new byte[10];
            newsock.ReceiveFrom(nhanthongtinclient, ref ep);

            int ketquaclient = Convert.ToInt32(Encoding.ASCII.GetString(nhanthongtinclient));
            Random rd = new Random();
            int ketquangaunhien = rd.Next(0, 2);

            if ((ketquangaunhien == 0 && ketquaclient == 0) || (ketquangaunhien == 1 && ketquaclient == 1) || (ketquangaunhien == 2 && ketquaclient == 2))
            {
                byte[] guithongdiep = Encoding.UTF8.GetBytes("Hòa");
                newsock.SendTo(guithongdiep, ep);
            }
            else if ((ketquangaunhien == 0 && ketquaclient == 1) || (ketquangaunhien == 1 && ketquaclient == 2) || (ketquangaunhien == 2 && ketquaclient == 0))
            {
                byte[] guithongdiep = Encoding.UTF8.GetBytes("Thắng");
                newsock.SendTo(guithongdiep, ep);
            }
            else
            {
                byte[] guithongdiep = Encoding.UTF8.GetBytes("Thua");
                newsock.SendTo(guithongdiep, ep);
            }
        }
    }
}
