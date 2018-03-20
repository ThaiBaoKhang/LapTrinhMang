namespace OanTuXi_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblKetqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.lblChon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(86, 186);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(97, 24);
            this.lblKetqua.TabIndex = 13;
            this.lblKetqua.Text = "lblKetqua";
            this.lblKetqua.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kết quả:";
            // 
            // btnBao
            // 
            this.btnBao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBao.BackgroundImage")));
            this.btnBao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBao.Location = new System.Drawing.Point(288, 72);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(81, 78);
            this.btnBao.TabIndex = 11;
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnBua
            // 
            this.btnBua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBua.BackgroundImage")));
            this.btnBua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBua.Location = new System.Drawing.Point(155, 72);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(83, 78);
            this.btnBua.TabIndex = 10;
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnKeo
            // 
            this.btnKeo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKeo.BackgroundImage")));
            this.btnKeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKeo.Location = new System.Drawing.Point(27, 72);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(83, 78);
            this.btnKeo.TabIndex = 9;
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChon.Location = new System.Drawing.Point(86, 18);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(82, 24);
            this.lblChon.TabIndex = 8;
            this.lblChon.Text = "lblChon";
            this.lblChon.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bạn chọn:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(196, 247);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(107, 20);
            this.lblTinhTrang.TabIndex = 14;
            this.lblTinhTrang.Text = "lblTinhTrang";
            this.lblTinhTrang.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 284);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTinhTrang;
    }
}

