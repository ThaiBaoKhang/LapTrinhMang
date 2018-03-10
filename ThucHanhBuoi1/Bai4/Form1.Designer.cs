namespace Bai4
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
            this.rtbTen = new System.Windows.Forms.RichTextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Những máy trong cùng mạng LAN";
            // 
            // rtbTen
            // 
            this.rtbTen.Location = new System.Drawing.Point(23, 28);
            this.rtbTen.Name = "rtbTen";
            this.rtbTen.ReadOnly = true;
            this.rtbTen.Size = new System.Drawing.Size(550, 261);
            this.rtbTen.TabIndex = 1;
            this.rtbTen.Text = "";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(477, 305);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 28);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(212, 313);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(66, 13);
            this.lblTinhTrang.TabIndex = 3;
            this.lblTinhTrang.Text = "lblTinhTrang";
            this.lblTinhTrang.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 356);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.rtbTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbTen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTinhTrang;
    }
}

