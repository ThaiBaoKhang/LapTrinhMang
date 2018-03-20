using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace OanTuXi
{
    public partial class Form1 : Form
    {
        int recv;
        IPEndPoint ipep;
        Socket newsock;        
        byte[] data;
        IPEndPoint client;

        public Form1()
        {
            InitializeComponent();           
        }

        public void KetNoiClient()
        {
            byte[] data = new byte[1024];
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(IPAddress.Any, 9050);         
            newsock.Bind(ipep);
            EndPoint ep = ipep;
            lblTinhTrang.Text = "Server đang mở!";

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
       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            newsock.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoiClient();            
        }
    }
}
