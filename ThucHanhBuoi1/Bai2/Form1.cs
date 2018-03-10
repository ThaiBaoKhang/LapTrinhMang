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

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbChon.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int chon = cbbChon.SelectedIndex;
            string nhapip = msktxbIP.Text;
            IPAddress address;
            if (chon == 0)
            {
                try
                {
                    if (nhapip.Contains(" "))
                    {
                        nhapip = msktxbIP.Text.Replace(" ", "");
                    }
                    if (IPAddress.TryParse(nhapip, out address))
                    {
                        IPHostEntry chuyen = Dns.GetHostEntry(nhapip);
                        string tenmien = chuyen.HostName;
                        txbXuat.Text = tenmien;
                    }
                    else
                    {
                        txbXuat.Text = "Địa chỉ IP ko hợp lệ!";
                    }                    
                }
                catch
                {
                    txbXuat.Text = "Không tìm thấy tên miền phù hợp!";
                }
            }
            else
            {
                IPHostEntry layten = Dns.GetHostEntry(txbNhap.Text);
                IPAddress[] ip = layten.AddressList;
                for (int i = 0; i < ip.Length; i++)
                {
                    txbXuat.Text = ip[i].ToString();
                }
            }
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int chon = cbbChon.SelectedIndex;
            if (chon == 0)
            {
                lblNameNhap.Text = "Nhập vào địa chỉ IP";
                lblNameXuat.Text = "Tên miền là: ";
                msktxbIP.Visible = true;
                txbNhap.Visible = false;
                txbNhap.Clear();
                txbXuat.Clear();
                msktxbIP.Clear();
            }
            else
            {
                lblNameNhap.Text = "Nhập vào tên miền";
                lblNameXuat.Text = "Địa chỉ IP là: ";
                msktxbIP.Visible = false;
                txbNhap.Visible = true;
                txbNhap.Clear();
                txbXuat.Clear();
                msktxbIP.Clear();
            }
        }

        private void msktxbIP_KeyDown(object sender, KeyEventArgs e)
        {
            // Cycle through the mask fields  
            if (e.KeyCode == Keys.Tab)
            {
                int pos = msktxbIP.SelectionStart;
                int max = (msktxbIP.MaskedTextProvider.Length - msktxbIP.MaskedTextProvider.EditPositionCount);
                int nextField = 0;

                for (int i = 0; i < msktxbIP.MaskedTextProvider.Length; i++)
                {
                    if (!msktxbIP.MaskedTextProvider.IsEditPosition(i) && (pos + max) >= i)
                        nextField = i;
                }
                nextField += 1;

                // We're done, enable the TabStop property again  
                if (pos == nextField)
                    msktxbIP_Leave(this, e);

                msktxbIP.SelectionStart = nextField;
            }
        }

        private void msktxbIP_Enter(object sender, EventArgs e)
        {
            // Resets the cursor when we enter the textbox  
            msktxbIP.SelectionStart = 0;
            // Disable the TabStop property to prevent the form and its controls to catch the Tab key  
            foreach (Control c in this.Controls)
                c.TabStop = false;
        }

        private void msktxbIP_Leave(object sender, EventArgs e)
        {
            // Resets the cursor when we leave the textbox  
            msktxbIP.SelectionStart = 0;
            // Enable the TabStop property so we can cycle through the form controls again  
            foreach (Control c in this.Controls)
                c.TabStop = true;
        }
    }
}
