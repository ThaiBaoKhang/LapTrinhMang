using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientKiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool PingHost(string IP, int Port)
        {
            try
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IP), Port);
                TcpClient server = new TcpClient();                
                IAsyncResult ar = server.BeginConnect(IP, Port, null, null);
                System.Threading.WaitHandle wh = ar.AsyncWaitHandle;
                try
                {
                    if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5), false))
                    {
                        server.Close();
                        return false;
                    }
                    server.EndConnect(ar);
                    return true;
                }
                finally
                {
                    wh.Close();
                }
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public bool PingHostUDP(string IP, int Port)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IP), Port);
            UdpClient udp = new UdpClient();
            udp.Client.SendTimeout = 5000;
            udp.Client.ReceiveTimeout = 5000;
            udp.Connect(ip);
            byte[] data = Encoding.ASCII.GetBytes("Test");
            udp.Send(data, data.Length);
            try
            {
                udp.Receive(ref ip);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void Async_LongRunningTask(object state) // giới hạn mức not responding cho application
        {          
            string ip = txbNhap.Text.Trim();
            for (int i = 0; i < 65535; i++)
            {
                lblcong.Text = i.ToString();
                if (PingHost(ip, i) == true)
                {
                    rtbTinhTrang.AppendText("TCP Port: " + i + " ----- ");
                    rtbTinhTrang.SelectionColor = Color.Green;
                    rtbTinhTrang.SelectionFont = new Font(rtbTinhTrang.Font, FontStyle.Bold);
                    rtbTinhTrang.AppendText("mở\r\n");                  
                }
                else
                {                                 
                    rtbTinhTrang.AppendText("TCP Port: " + i + " ----- ");
                    rtbTinhTrang.SelectionColor = Color.Red;
                    rtbTinhTrang.SelectionFont = new Font(rtbTinhTrang.Font, FontStyle.Bold);
                    rtbTinhTrang.AppendText("đóng\r\n");
                }
                if (PingHostUDP(ip, i) == true)
                {
                    rtbTinhTrang.AppendText("UDP Port: " + i + " ----- ");
                    rtbTinhTrang.SelectionColor = Color.Green;
                    rtbTinhTrang.SelectionFont = new Font(rtbTinhTrang.Font, FontStyle.Bold);
                    rtbTinhTrang.AppendText("mở\r\n");
                }
                else
                {
                    rtbTinhTrang.AppendText("UDP Port: " + i + " ----- ");
                    rtbTinhTrang.SelectionColor = Color.Red;
                    rtbTinhTrang.SelectionFont = new Font(rtbTinhTrang.Font, FontStyle.Bold);
                    rtbTinhTrang.AppendText("đóng\r\n");
                }
            }
            Thread.Sleep(5000);
            this.Invoke((MethodInvoker)delegate
            {
                this.Cursor = Cursors.Default;
            });
            Thread.Sleep(2000);
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            lblcong.Visible = true;
            btnkiemtra.Enabled = false;
            ThreadPool.QueueUserWorkItem(Async_LongRunningTask, "btnkiemtra_Click");
        }
    }
}
