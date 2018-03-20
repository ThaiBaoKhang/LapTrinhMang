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
        public static string ipV4(string hostname)
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(hostname);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {                  
                    return ip.ToString();
                }
            }
            return string.Empty;
        }

        static void Main(string[] args)
        {
            Socket newsock;
            IPEndPoint ipep;
            string hostname = Dns.GetHostName();           
            string ip = ipV4(hostname);
            byte[] data = new byte[1024];
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(IPAddress.Any, 9050);
            newsock.Bind(ipep);
            EndPoint ep = ipep;
            Console.WriteLine("Server dang mo!");
           
            byte[] nhanthongtinclient = new byte[10];
            newsock.ReceiveFrom(nhanthongtinclient, ref ep);

            int ketquaclient = Convert.ToInt32(Encoding.ASCII.GetString(nhanthongtinclient));
            Random rd = new Random();
            int ketquangaunhien = rd.Next(0, 2);

            if ((ketquangaunhien == 0 && ketquaclient == 0) || (ketquangaunhien == 1 && ketquaclient == 1) || (ketquangaunhien == 2 && ketquaclient == 2))
            {
                byte[] guithongdiep = Encoding.ASCII.GetBytes("Hòa");
                newsock.SendTo(guithongdiep, ep);
            }
            else if ((ketquangaunhien == 0 && ketquaclient == 1) || (ketquangaunhien == 1 && ketquaclient == 2) || (ketquangaunhien == 2 && ketquaclient == 0))
            {
                byte[] guithongdiep = Encoding.ASCII.GetBytes("Bạn thắng");
                newsock.SendTo(guithongdiep, ep);
            }
            else
            {
                byte[] guithongdiep = Encoding.ASCII.GetBytes("Bạn thua !!");
                newsock.SendTo(guithongdiep, ep);
            }
        }
    }
}
