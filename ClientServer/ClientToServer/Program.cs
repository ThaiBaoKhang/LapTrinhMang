using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientToServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.KetNoiDenServer();
        }
    }    
}
