using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Server sv = new Server();
            sv.KetNoiClient();
        }
    }    
}
