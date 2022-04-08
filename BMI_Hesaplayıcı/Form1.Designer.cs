
namespace BMI_Hesaplayıcı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.assisman = new System.Windows.Forms.PictureBox();
            this.sisman = new System.Windows.Forms.PictureBox();
            this.kilolu = new System.Windows.Forms.PictureBox();
            this.saglikli = new System.Windows.Forms.PictureBox();
            this.zayif = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilolu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saglikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayif)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnhesapla);
            this.groupBox1.Controls.Add(this.txtkilo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HESAPLAMA EKRANI";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnreset.Location = new System.Drawing.Point(301, 373);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(175, 29);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "SONUÇLARI SIFIRLA";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(202, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 24);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "VÜCUT KİTLE ENDEKSİNİZ :";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.YellowGreen;
            this.btnhesapla.Location = new System.Drawing.Point(202, 235);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(161, 29);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(202, 168);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(161, 27);
            this.txtkilo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilonuzu Giriniz ( kg )";
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(202, 88);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(161, 27);
            this.txtboy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boyunuzu Giriniz ( cm )";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.assisman);
            this.groupBox2.Controls.Add(this.sisman);
            this.groupBox2.Controls.Add(this.kilolu);
            this.groupBox2.Controls.Add(this.saglikli);
            this.groupBox2.Controls.Add(this.zayif);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(500, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLGİ EKRANI";
            // 
            // assisman
            // 
            this.assisman.Image = global::BMI_Hesaplayıcı.Properties.Resources.carpi;
            this.assisman.Location = new System.Drawing.Point(287, 352);
            this.assisman.Name = "assisman";
            this.assisman.Size = new System.Drawing.Size(50, 50);
            this.assisman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assisman.TabIndex = 16;
            this.assisman.TabStop = false;
            // 
            // sisman
            // 
            this.sisman.Image = global::BMI_Hesaplayıcı.Properties.Resources.carpi;
            this.sisman.Location = new System.Drawing.Point(287, 278);
            this.sisman.Name = "sisman";
            this.sisman.Size = new System.Drawing.Size(50, 50);
            this.sisman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sisman.TabIndex = 15;
            this.sisman.TabStop = false;
            // 
            // kilolu
            // 
            this.kilolu.Image = global::BMI_Hesaplayıcı.Properties.Resources.carpi;
            this.kilolu.Location = new System.Drawing.Point(287, 195);
            this.kilolu.Name = "kilolu";
            this.kilolu.Size = new System.Drawing.Size(50, 50);
            this.kilolu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kilolu.TabIndex = 14;
            this.kilolu.TabStop = false;
            // 
            // saglikli
            // 
            this.saglikli.Image = global::BMI_Hesaplayıcı.Properties.Resources.carpi;
            this.saglikli.Location = new System.Drawing.Point(287, 124);
            this.saglikli.Name = "saglikli";
            this.saglikli.Size = new System.Drawing.Size(50, 50);
            this.saglikli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saglikli.TabIndex = 13;
            this.saglikli.TabStop = false;
            // 
            // zayif
            // 
            this.zayif.Image = global::BMI_Hesaplayıcı.Properties.Resources.carpi;
            this.zayif.Location = new System.Drawing.Point(287, 42);
            this.zayif.Name = "zayif";
            this.zayif.Size = new System.Drawing.Size(50, 50);
            this.zayif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zayif.TabIndex = 12;
            this.zayif.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "AŞIRI ŞİŞMAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "ŞİŞMAN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "KİLOLU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "SAĞLIKLI";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "ZAYIF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "40-60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "30-40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "25-30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "18,5-25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "10-18,15";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Crimson;
            this.btnexit.Location = new System.Drawing.Point(878, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(165, 29);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Programdan Çıkış";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(978, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "©onurkalyoncu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1055, 428);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI HESAPLAYICI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilolu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saglikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox assisman;
        private System.Windows.Forms.PictureBox sisman;
        private System.Windows.Forms.PictureBox kilolu;
        private System.Windows.Forms.PictureBox saglikli;
        private System.Windows.Forms.PictureBox zayif;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label14;
    }
}

