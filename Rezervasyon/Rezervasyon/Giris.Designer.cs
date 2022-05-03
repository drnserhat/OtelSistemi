
namespace Rezervasyon
{
    partial class Giris
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
            this.lbl12 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtKul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl12.Location = new System.Drawing.Point(508, 339);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(0, 39);
            this.lbl12.TabIndex = 31;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGiris.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnGiris.Location = new System.Drawing.Point(508, 384);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(6);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(246, 77);
            this.btnGiris.TabIndex = 30;
            this.btnGiris.Text = " G I R I S";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Khaki;
            this.txtPass.Location = new System.Drawing.Point(508, 267);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(246, 27);
            this.txtPass.TabIndex = 28;
            this.txtPass.Text = "Parola";
            this.txtPass.MouseEnter += new System.EventHandler(this.txtPass_MouseEnter);
            // 
            // txtKul
            // 
            this.txtKul.BackColor = System.Drawing.Color.Khaki;
            this.txtKul.Location = new System.Drawing.Point(508, 211);
            this.txtKul.Margin = new System.Windows.Forms.Padding(6);
            this.txtKul.Name = "txtKul";
            this.txtKul.Size = new System.Drawing.Size(246, 27);
            this.txtKul.TabIndex = 29;
            this.txtKul.Text = "Kullanıcı Adı";
            this.txtKul.MouseEnter += new System.EventHandler(this.txtKul_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezervasyon.Properties.Resources.el_tovar_hotel_wallpaper_1280x720;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtKul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtKul;
    }
}

