namespace Bai1
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
            this.btnXemDC = new System.Windows.Forms.Button();
            this.rtbIP = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXemDC
            // 
            this.btnXemDC.Location = new System.Drawing.Point(407, 176);
            this.btnXemDC.Name = "btnXemDC";
            this.btnXemDC.Size = new System.Drawing.Size(101, 37);
            this.btnXemDC.TabIndex = 9;
            this.btnXemDC.Text = "Xem địa chỉ";
            this.btnXemDC.UseVisualStyleBackColor = true;
            this.btnXemDC.Click += new System.EventHandler(this.btnXemDC_Click);
            // 
            // rtbIP
            // 
            this.rtbIP.Location = new System.Drawing.Point(177, 82);
            this.rtbIP.Name = "rtbIP";
            this.rtbIP.ReadOnly = true;
            this.rtbIP.Size = new System.Drawing.Size(290, 78);
            this.rtbIP.TabIndex = 8;
            this.rtbIP.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ IP máy cục bộ";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(177, 32);
            this.txbTen.Name = "txbTen";
            this.txbTen.ReadOnly = true;
            this.txbTen.Size = new System.Drawing.Size(290, 20);
            this.txbTen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên máy tính";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 242);
            this.Controls.Add(this.btnXemDC);
            this.Controls.Add(this.rtbIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemDC;
        private System.Windows.Forms.RichTextBox rtbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label1;
    }
}

