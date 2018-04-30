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
using System.Windows.Forms;

namespace MaTran_Client
{
    public partial class Form1 : Form
    {        
        int z = 0;
        int lk = 0;
        int dem = 0;
        int dem2 = 0;
        int[,] mt1;
        int[,] mt2;

        Socket server;
        IPEndPoint ipe;
        Thread ketnoi;
        TcpClient clientSocket = new TcpClient();

        public Form1()
        {
            InitializeComponent();      
        }

        private void btnTaoMaTran1_Click(object sender, EventArgs e)
        {
            if (chonsocot1.Value != chonsodong2.Value)
            {
                MessageBox.Show("Số cột ma trận 1 phải bằng số dòng ma trận 2!");
            }
            else
            {             
                int chieucaotxb = 20;
                int chieudaitxb = 19;
                int khoangcach = 10;
                int a = 6;
                int b = 19;
                int c = 0;
                int i = (int)chonsodong1.Value;
                int j = (int)chonsocot1.Value;              
                for (int y = 0; y < i; y++)
                {
                    b = 19;
                    a = a + 10;
                    for (int x = 0; x < j; x++)
                    {
                        TextBox txb = new TextBox();
                        txb.Top = a + (y * chieucaotxb + khoangcach) + 5;
                        txb.Left = b + (x * chieudaitxb + khoangcach) + 5;
                        b = b + 10;
                        txb.Name = "txb" + c;
                        z = c;
                        c++;
                        txb.Width = chieudaitxb;
                        txb.Height = chieucaotxb;
                        grbnhap.Controls.Add(txb);                      
                    }
                }
                chonsodong1.Enabled = false;
                chonsocot1.Enabled = false;
            }
        }

        private void btnTaoMaTran2_Click(object sender, EventArgs e)
        {
            if (chonsocot1.Value != chonsodong2.Value)
            {
                MessageBox.Show("Số cột ma trận 1 phải bằng số dòng ma trận 2!");
            }
            else
            {
                int chieucaotxb = 20;
                int chieudaitxb = 19;
                int khoangcach = 10;
                int a = 6;
                int b = 19;
                int c = 0;
                int i = (int)chonsodong2.Value;
                int j = (int)chonsocot2.Value;
                for (int y = 0; y < i; y++)
                {
                    b = 19;
                    a = a + 10;
                    for (int x = 0; x < j; x++)
                    {
                        TextBox txb = new TextBox();
                        txb.Top = a + (y * chieucaotxb + khoangcach) + 5;
                        txb.Left = b + (x * chieudaitxb + khoangcach) + 5;
                        b = b + 10;
                        txb.Name = "txc" + c;
                        lk = c;
                        c++;
                        txb.Width = chieudaitxb;
                        txb.Height = chieucaotxb;
                        grbnhap2.Controls.Add(txb);
                    }
                }
                chonsodong2.Enabled = false;
                chonsocot2.Enabled = false;
            }
        }
        // luu mang
        private void Test_Click(object sender, EventArgs e)
        {         
           int i = (int)chonsodong1.Value;
            int j = (int)chonsocot1.Value;            
            mt1 = new int[i, j];            
            for (int r = 0; r < i; r++)
            {                
                for (int l = 0; l < j; l++)
                {
                    if (dem <= z)
                    {
                        mt1[r, l] = Convert.ToInt32(((TextBox)grbnhap.Controls["txb" + dem]).Text);
                        
                        dem++;
                    }                  
                }
            }

            int k = (int)chonsodong2.Value;
            int s = (int)chonsocot2.Value;
            mt2 = new int[k, s];

            for (int r = 0; r < k; r++)
            {
                for (int l = 0; l < s; l++)
                {
                    if (dem2 <= lk)
                    {                       
                        mt2[r, l] = Convert.ToInt32(((TextBox)grbnhap2.Controls["txc" + dem2]).Text);
                        dem2++;
                    }
                }
            }          
        }           

        private void btnGiai_Click_1(object sender, EventArgs e)
        {
            int i = (int)chonsodong1.Value;
            int j = (int)chonsocot1.Value;
            mt1 = new int[i, j];
            for (int r = 0; r < i; r++)
            {
                for (int l = 0; l < j; l++)
                {
                    if (dem <= z)
                    {
                        mt1[r, l] = Convert.ToInt32(((TextBox)grbnhap.Controls["txb" + dem]).Text);

                        dem++;
                    }
                }
            }

            int k = (int)chonsodong2.Value;
            int s = (int)chonsocot2.Value;
            mt2 = new int[k, s];

            for (int r = 0; r < k; r++)
            {
                for (int l = 0; l < s; l++)
                {
                    if (dem2 <= lk)
                    {
                        mt2[r, l] = Convert.ToInt32(((TextBox)grbnhap2.Controls["txc" + dem2]).Text);
                        dem2++;
                    }
                }
            }
            int rowsmatrix1 = mt1.GetLength(0);
            int columnmatrix1 = mt1.GetLength(1);
            int rowsmatrix2 = mt2.GetLength(0);
            int columnmatrix2 = mt2.GetLength(1);
            try
            {
                NetworkStream serverStream = clientSocket.GetStream();               
                byte[] outStream = Encoding.ASCII.GetBytes("Ma tran 1 co " + rowsmatrix1 + " dong " + columnmatrix1 + " cot$");            
                byte[] outStream2 = Encoding.ASCII.GetBytes("Ma tran 2 co " + rowsmatrix2 + " dong " + columnmatrix2 + " cot$");              
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Write(outStream2, 0, outStream.Length);             
                serverStream.Flush();

                byte[] inStream = new byte[1024];
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.ASCII.GetString(inStream);
                txbTest.Text = "Data from Server : " + returndata;
            }
            catch 
            {
                MessageBox.Show("Kết nối đến server đã bị đóng! Thoát chương trình ");
                this.Close();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 9050);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server");
                this.Close();
                return;                
            }
            
        }
    }
}
  

