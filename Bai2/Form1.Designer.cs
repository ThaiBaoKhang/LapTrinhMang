namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.lblNameNhap = new System.Windows.Forms.Label();
            this.lblNameXuat = new System.Windows.Forms.Label();
            this.txbNhap = new System.Windows.Forms.TextBox();
            this.txbXuat = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.msktxbIP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại muốn nhập";
            // 
            // cbbChon
            // 
            this.cbbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.Items.AddRange(new object[] {
            "IP sang tên miền",
            "Tên miền sang IP"});
            this.cbbChon.Location = new System.Drawing.Point(203, 35);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(185, 21);
            this.cbbChon.TabIndex = 1;
            this.cbbChon.SelectedIndexChanged += new System.EventHandler(this.cbbChon_SelectedIndexChanged);
            // 
            // lblNameNhap
            // 
            this.lblNameNhap.AutoSize = true;
            this.lblNameNhap.Location = new System.Drawing.Point(46, 99);
            this.lblNameNhap.Name = "lblNameNhap";
            this.lblNameNhap.Size = new System.Drawing.Size(71, 13);
            this.lblNameNhap.TabIndex = 2;
            this.lblNameNhap.Text = "lblNameNhap";
            // 
            // lblNameXuat
            // 
            this.lblNameXuat.AutoSize = true;
            this.lblNameXuat.Location = new System.Drawing.Point(46, 157);
            this.lblNameXuat.Name = "lblNameXuat";
            this.lblNameXuat.Size = new System.Drawing.Size(67, 13);
            this.lblNameXuat.TabIndex = 3;
            this.lblNameXuat.Text = "lblNameXuat";
            // 
            // txbNhap
            // 
            this.txbNhap.Location = new System.Drawing.Point(203, 96);
            this.txbNhap.Name = "txbNhap";
            this.txbNhap.Size = new System.Drawing.Size(185, 20);
            this.txbNhap.TabIndex = 2;
            // 
            // txbXuat
            // 
            this.txbXuat.Location = new System.Drawing.Point(203, 154);
            this.txbXuat.Name = "txbXuat";
            this.txbXuat.ReadOnly = true;
            this.txbXuat.Size = new System.Drawing.Size(185, 20);
            this.txbXuat.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(167, 218);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(158, 36);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // msktxbIP
            // 
            this.msktxbIP.Location = new System.Drawing.Point(203, 96);
            this.msktxbIP.Mask = "000\\.000\\.000\\.000";
            this.msktxbIP.Name = "msktxbIP";
            this.msktxbIP.ResetOnSpace = false;
            this.msktxbIP.Size = new System.Drawing.Size(185, 20);
            this.msktxbIP.TabIndex = 1;
            this.msktxbIP.Visible = false;
            this.msktxbIP.Enter += new System.EventHandler(this.msktxbIP_Enter);
            this.msktxbIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxbIP_KeyDown);
            this.msktxbIP.Leave += new System.EventHandler(this.msktxbIP_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.msktxbIP);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txbXuat);
            this.Controls.Add(this.txbNhap);
            this.Controls.Add(this.lblNameXuat);
            this.Controls.Add(this.lblNameNhap);
            this.Controls.Add(this.cbbChon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.Label lblNameNhap;
        private System.Windows.Forms.Label lblNameXuat;
        private System.Windows.Forms.TextBox txbNhap;
        private System.Windows.Forms.TextBox txbXuat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.MaskedTextBox msktxbIP;
    }
}

