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

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ipmay = "";
            string p = "";
            string tenhost = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(tenhost);
            foreach (IPAddress iptrongmang in ip)
            {
                ipmay = iptrongmang.ToString();
            }
            try
            {
                string[] tachchuoi = ipmay.Split('.');
                int ip1 = Int32.Parse(tachchuoi[0]);
                int ip2 = Int32.Parse(tachchuoi[1]);
                int ip3 = Int32.Parse(tachchuoi[2]);
                string s = ip1 + "." + ip2 + "." + ip3 + ".";
                for (int i = 1; i < 255; i++)
                {
                    lblTinhTrang.Visible = true;
                    lblTinhTrang.Text = "Đang tìm, xin hãy đợi một vài phút.";
                    p = s + i;
                    IPHostEntry ips = Dns.Resolve(p);                    
                    string hostname = ips.HostName;
                    lblTinhTrang.Text = "Đang tìm, xin hãy đợi một vài phút..";
                    rtbTen.AppendText(hostname + " \r\n");
                    lblTinhTrang.Text = "Đang tìm, xin hãy đợi một vài phút...";
                }
            }
            catch
            {
                MessageBox.Show("Chương trình không dành cho máy sử dụng IPV6!");
                btnTim.Enabled = false;
                return;
            }           

        }
    }
}
