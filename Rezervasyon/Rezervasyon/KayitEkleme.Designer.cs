
namespace Rezervasyon
{
    partial class KayitEkleme
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.dgwOdalar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOdalar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCikisTarihi = new System.Windows.Forms.TextBox();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbOda1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAD1 = new System.Windows.Forms.TextBox();
            this.txtSoyad1 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtCikisTarihi1 = new System.Windows.Forms.TextBox();
            this.rbErkek1 = new System.Windows.Forms.RadioButton();
            this.rbKadin1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGirisTarihi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(150, 403);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(151, 67);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "KAYİT";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // dgwOdalar
            // 
            this.dgwOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOdalar.Location = new System.Drawing.Point(12, 45);
            this.dgwOdalar.Name = "dgwOdalar";
            this.dgwOdalar.RowHeadersWidth = 51;
            this.dgwOdalar.RowTemplate.Height = 29;
            this.dgwOdalar.Size = new System.Drawing.Size(533, 504);
            this.dgwOdalar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MİSAFİR ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ODA NO: ";
            // 
            // cbOdalar
            // 
            this.cbOdalar.FormattingEnabled = true;
            this.cbOdalar.Location = new System.Drawing.Point(135, 87);
            this.cbOdalar.Name = "cbOdalar";
            this.cbOdalar.Size = new System.Drawing.Size(175, 28);
            this.cbOdalar.TabIndex = 3;
            this.cbOdalar.Text = "Oda numarası seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "MİSAFİR SOYADI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "TEL-NO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cinsiyet:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(150, 138);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(151, 27);
            this.txtAD.TabIndex = 5;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(150, 189);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(151, 27);
            this.txtSOYAD.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(150, 234);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(151, 27);
            this.txtTel.TabIndex = 5;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(150, 329);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 24);
            this.rbErkek.TabIndex = 7;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(233, 329);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(68, 24);
            this.rbKadin.TabIndex = 7;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadin";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "ÇIKIŞ TARİHİ:";
            // 
            // txtCikisTarihi
            // 
            this.txtCikisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCikisTarihi.Location = new System.Drawing.Point(150, 280);
            this.txtCikisTarihi.Name = "txtCikisTarihi";
            this.txtCikisTarihi.Size = new System.Drawing.Size(151, 27);
            this.txtCikisTarihi.TabIndex = 5;
            this.txtCikisTarihi.Text = "Örn; 01.01.2022 ";
            this.txtCikisTarihi.MouseHover += new System.EventHandler(this.txtCikisTarihi_MouseHover);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(165, 393);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(151, 67);
            this.btnRezervasyon.TabIndex = 8;
            this.btnRezervasyon.Text = "REZERVASYON";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MİSAFİR ADI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "MİSAFİR SOYADI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "TEL-NO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "ÇIKIŞ TARİHİ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cinsiyet:";
            // 
            // cbOda1
            // 
            this.cbOda1.FormattingEnabled = true;
            this.cbOda1.Location = new System.Drawing.Point(165, 79);
            this.cbOda1.Name = "cbOda1";
            this.cbOda1.Size = new System.Drawing.Size(175, 28);
            this.cbOda1.TabIndex = 3;
            this.cbOda1.Text = "Oda numarası seçiniz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(41, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "ODA NO: ";
            // 
            // txtAD1
            // 
            this.txtAD1.Location = new System.Drawing.Point(180, 130);
            this.txtAD1.Name = "txtAD1";
            this.txtAD1.Size = new System.Drawing.Size(151, 27);
            this.txtAD1.TabIndex = 5;
            // 
            // txtSoyad1
            // 
            this.txtSoyad1.Location = new System.Drawing.Point(180, 181);
            this.txtSoyad1.Name = "txtSoyad1";
            this.txtSoyad1.Size = new System.Drawing.Size(151, 27);
            this.txtSoyad1.TabIndex = 5;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(180, 226);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(151, 27);
            this.txtTel1.TabIndex = 5;
            // 
            // txtCikisTarihi1
            // 
            this.txtCikisTarihi1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCikisTarihi1.Location = new System.Drawing.Point(180, 316);
            this.txtCikisTarihi1.Name = "txtCikisTarihi1";
            this.txtCikisTarihi1.Size = new System.Drawing.Size(151, 27);
            this.txtCikisTarihi1.TabIndex = 5;
            this.txtCikisTarihi1.Text = "Örn; 01.01.2022 ";
            this.txtCikisTarihi1.MouseHover += new System.EventHandler(this.txtCikisTarihi_MouseHover);
            // 
            // rbErkek1
            // 
            this.rbErkek1.AutoSize = true;
            this.rbErkek1.Location = new System.Drawing.Point(178, 353);
            this.rbErkek1.Name = "rbErkek1";
            this.rbErkek1.Size = new System.Drawing.Size(65, 24);
            this.rbErkek1.TabIndex = 7;
            this.rbErkek1.TabStop = true;
            this.rbErkek1.Text = "Erkek";
            this.rbErkek1.UseVisualStyleBackColor = true;
            // 
            // rbKadin1
            // 
            this.rbKadin1.AutoSize = true;
            this.rbKadin1.Location = new System.Drawing.Point(261, 353);
            this.rbKadin1.Name = "rbKadin1";
            this.rbKadin1.Size = new System.Drawing.Size(68, 24);
            this.rbKadin1.TabIndex = 7;
            this.rbKadin1.TabStop = true;
            this.rbKadin1.Text = "Kadin";
            this.rbKadin1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "GİRİŞ TARİHİ:";
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtGirisTarihi.Location = new System.Drawing.Point(178, 270);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.Size = new System.Drawing.Size(151, 27);
            this.txtGirisTarihi.TabIndex = 10;
            this.txtGirisTarihi.Text = "Örn; 01.01.2022";
            this.txtGirisTarihi.MouseHover += new System.EventHandler(this.txtGirisTarihi_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOdalar);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.txtSOYAD);
            this.groupBox1.Controls.Add(this.txtCikisTarihi);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Location = new System.Drawing.Point(551, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 504);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MİSAFİR KAYIT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGirisTarihi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnRezervasyon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.rbKadin1);
            this.groupBox2.Controls.Add(this.cbOda1);
            this.groupBox2.Controls.Add(this.rbErkek1);
            this.groupBox2.Controls.Add(this.txtAD1);
            this.groupBox2.Controls.Add(this.txtCikisTarihi1);
            this.groupBox2.Controls.Add(this.txtSoyad1);
            this.groupBox2.Controls.Add(this.txtTel1);
            this.groupBox2.Location = new System.Drawing.Point(890, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 504);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REZERVASYON";
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwOdalar);
            this.Name = "Rezervasyon";
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView dgwOdalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOdalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCikisTarihi;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbOda1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAD1;
        private System.Windows.Forms.TextBox txtSoyad1;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtCikisTarihi1;
        private System.Windows.Forms.RadioButton rbErkek1;
        private System.Windows.Forms.RadioButton rbKadin1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGirisTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}