﻿namespace ThongBaoEmail
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblchuadoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbNoidung = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các email chưa đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chưa đọc";
            // 
            // lblchuadoc
            // 
            this.lblchuadoc.AutoSize = true;
            this.lblchuadoc.Location = new System.Drawing.Point(89, 72);
            this.lblchuadoc.Name = "lblchuadoc";
            this.lblchuadoc.Size = new System.Drawing.Size(59, 13);
            this.lblchuadoc.TabIndex = 2;
            this.lblchuadoc.Text = "lblchuadoc";
            this.lblchuadoc.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung email mới nhất";
            // 
            // rtbNoidung
            // 
            this.rtbNoidung.Location = new System.Drawing.Point(28, 182);
            this.rtbNoidung.Name = "rtbNoidung";
            this.rtbNoidung.Size = new System.Drawing.Size(434, 135);
            this.rtbNoidung.TabIndex = 4;
            this.rtbNoidung.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiêu đề";
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Location = new System.Drawing.Point(89, 151);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(46, 13);
            this.lbltieude.TabIndex = 6;
            this.lbltieude.Text = "lbltieude";
            this.lbltieude.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 340);
            this.Controls.Add(this.lbltieude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbNoidung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblchuadoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblchuadoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbNoidung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltieude;
    }
}

