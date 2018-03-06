using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemDC_Click(object sender, EventArgs e)
        {
            string hostname = Dns.GetHostName();
            txbTen.Text = hostname;
            IPAddress[] ip = Dns.GetHostAddresses(hostname);
            foreach (IPAddress iptrongmang in ip)
            {
                rtbIP.AppendText(iptrongmang.ToString() + "\r\n");
                btnXemDC.Enabled = false;
            }
        }
    }
}
