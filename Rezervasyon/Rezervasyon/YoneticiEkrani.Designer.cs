
namespace Rezervasyon
{
    partial class YoneticiEkrani
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
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnMisafir = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnIstatislik = new System.Windows.Forms.Button();
            this.btnCalisan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.Color.Transparent;
            this.btnOdalar.BackgroundImage = global::Rezervasyon.Properties.Resources.room1;
            this.btnOdalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdalar.Location = new System.Drawing.Point(82, 114);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(163, 394);
            this.btnOdalar.TabIndex = 0;
            this.btnOdalar.UseVisualStyleBackColor = false;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnMisafir
            // 
            this.btnMisafir.BackgroundImage = global::Rezervasyon.Properties.Resources.holidays;
            this.btnMisafir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisafir.Location = new System.Drawing.Point(313, 114);
            this.btnMisafir.Name = "btnMisafir";
            this.btnMisafir.Size = new System.Drawing.Size(160, 394);
            this.btnMisafir.TabIndex = 0;
            this.btnMisafir.UseVisualStyleBackColor = true;
            this.btnMisafir.Click += new System.EventHandler(this.btnMisafir_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackgroundImage = global::Rezervasyon.Properties.Resources.booking;
            this.btnRezervasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyon.Location = new System.Drawing.Point(545, 114);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(160, 394);
            this.btnRezervasyon.TabIndex = 0;
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnIstatislik
            // 
            this.btnIstatislik.BackgroundImage = global::Rezervasyon.Properties.Resources.bar_chart;
            this.btnIstatislik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatislik.Location = new System.Drawing.Point(1058, 114);
            this.btnIstatislik.Name = "btnIstatislik";
            this.btnIstatislik.Size = new System.Drawing.Size(160, 394);
            this.btnIstatislik.TabIndex = 0;
            this.btnIstatislik.UseVisualStyleBackColor = true;
            this.btnIstatislik.Click += new System.EventHandler(this.btnIstatislik_Click);
            // 
            // btnCalisan
            // 
            this.btnCalisan.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisan.BackgroundImage = global::Rezervasyon.Properties.Resources.teamwork;
            this.btnCalisan.Location = new System.Drawing.Point(791, 114);
            this.btnCalisan.Name = "btnCalisan";
            this.btnCalisan.Size = new System.Drawing.Size(160, 394);
            this.btnCalisan.TabIndex = 2;
            this.btnCalisan.UseVisualStyleBackColor = false;
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezervasyon.Properties.Resources.el_tovar_hotel_wallpaper_1280x720;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnCalisan);
            this.Controls.Add(this.btnIstatislik);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMisafir);
            this.Controls.Add(this.btnOdalar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "YoneticiEkrani";
            this.Text = "YoneticiEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoneticiEkrani_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnMisafir;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnIstatislik;
        private System.Windows.Forms.Button btnCalisan;
    }
}