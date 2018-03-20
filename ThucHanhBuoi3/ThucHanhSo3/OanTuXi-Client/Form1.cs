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

namespace OanTuXi_Client
{
    public partial class Form1 : Form
    {
        IPEndPoint ipep;
        Socket server;
        EndPoint remote;       

        public Form1()
        {           
            InitializeComponent();
        }
        public void KetNoiServer()
        {            
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            remote = (EndPoint)ipep;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            lblChon.Text = "Kéo";
            byte[] guithongtin = Encoding.ASCII.GetBytes("0");
            server.SendTo(guithongtin, remote);
            byte[] nhanthongtin = new byte[20];
            lblKetqua.Text = Encoding.ASCII.GetString(nhanthongtin);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            lblChon.Text = "Búa";
            byte[] guithongtin = Encoding.ASCII.GetBytes("1");
            server.SendTo(guithongtin, remote);
            byte[] nhanthongtin = new byte[20];
            lblKetqua.Text = Encoding.ASCII.GetString(nhanthongtin);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            lblChon.Text = "Bao";
            byte[] guithongtin = Encoding.ASCII.GetBytes("2");
            server.SendTo(guithongtin, remote);
            byte[] nhanthongtin = new byte[20];
            lblKetqua.Text = Encoding.ASCII.GetString(nhanthongtin);
        }
    }
}
