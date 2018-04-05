namespace ClientKiemTra
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
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.rtbTinhTrang = new System.Windows.Forms.RichTextBox();
            this.lblcong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Location = new System.Drawing.Point(348, 24);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(63, 45);
            this.btnkiemtra.TabIndex = 11;
            this.btnkiemtra.Text = "Kiếm";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // rtbTinhTrang
            // 
            this.rtbTinhTrang.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTinhTrang.Location = new System.Drawing.Point(12, 96);
            this.rtbTinhTrang.Name = "rtbTinhTrang";
            this.rtbTinhTrang.ReadOnly = true;
            this.rtbTinhTrang.Size = new System.Drawing.Size(418, 146);
            this.rtbTinhTrang.TabIndex = 10;
            this.rtbTinhTrang.Text = "";
            // 
            // lblcong
            // 
            this.lblcong.AutoSize = true;
            this.lblcong.Location = new System.Drawing.Point(93, 63);
            this.lblcong.Name = "lblcong";
            this.lblcong.Size = new System.Drawing.Size(41, 13);
            this.lblcong.TabIndex = 9;
            this.lblcong.Text = "lblcong";
            this.lblcong.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kiểm tra cổng:";
            // 
            // txbNhap
            // 
            this.txbNhap.Location = new System.Drawing.Point(149, 24);
            this.txbNhap.Name = "txbNhap";
            this.txbNhap.Size = new System.Drawing.Size(184, 20);
            this.txbNhap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập vào IP của server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 254);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.rtbTinhTrang);
            this.Controls.Add(this.lblcong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.RichTextBox rtbTinhTrang;
        private System.Windows.Forms.Label lblcong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNhap;
        private System.Windows.Forms.Label label1;
    }
}

