
namespace Rezervasyon
{
    partial class Odalar
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
            this.components = new System.ComponentModel.Container();
            this.cbOdalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblStandart = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.blblOdaNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbOdalar
            // 
            this.cbOdalar.FormattingEnabled = true;
            this.cbOdalar.Location = new System.Drawing.Point(162, 100);
            this.cbOdalar.Name = "cbOdalar";
            this.cbOdalar.Size = new System.Drawing.Size(175, 28);
            this.cbOdalar.TabIndex = 0;
            this.cbOdalar.Text = "Oda numarası seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ODA NO: ";
            // 
            // btnOda
            // 
            this.btnOda.Location = new System.Drawing.Point(100, 148);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(203, 69);
            this.btnOda.TabIndex = 3;
            this.btnOda.Text = "Bilgileri Getir";
            this.btnOda.UseVisualStyleBackColor = true;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODA HAKKINDA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUcret);
            this.panel1.Controls.Add(this.lblStandart);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.blblOdaNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 367);
            this.panel1.TabIndex = 5;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUcret.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUcret.Location = new System.Drawing.Point(171, 226);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(0, 32);
            this.lblUcret.TabIndex = 6;
            // 
            // lblStandart
            // 
            this.lblStandart.AutoSize = true;
            this.lblStandart.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStandart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStandart.Location = new System.Drawing.Point(205, 164);
            this.lblStandart.Name = "lblStandart";
            this.lblStandart.Size = new System.Drawing.Size(0, 32);
            this.lblStandart.TabIndex = 6;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurum.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDurum.Location = new System.Drawing.Point(189, 108);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 32);
            this.lblDurum.TabIndex = 6;
            // 
            // blblOdaNo
            // 
            this.blblOdaNo.AutoSize = true;
            this.blblOdaNo.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blblOdaNo.ForeColor = System.Drawing.Color.DarkRed;
            this.blblOdaNo.Location = new System.Drawing.Point(126, 55);
            this.blblOdaNo.Name = "blblOdaNo";
            this.blblOdaNo.Size = new System.Drawing.Size(0, 32);
            this.blblOdaNo.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "ODA ÜCRETİ: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "ODA STANDARTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "ODA DURUMU:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.Location = new System.Drawing.Point(3, 55);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(112, 32);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "ODA NO:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rezervasyon.Properties.Resources._02;
            this.pictureBox1.Location = new System.Drawing.Point(356, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOdalar);
            this.Name = "Odalar";
            this.Text = "Odalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Odalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOdalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblStandart;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label blblOdaNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}