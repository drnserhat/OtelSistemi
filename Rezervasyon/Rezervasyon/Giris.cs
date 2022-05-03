using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=kayit;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM giris WHERE kul_adi='" + txtKul.Text + "' AND parola='" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Yaptınız:");
                YoneticiEkrani a = new YoneticiEkrani();

                this.Hide();
                a.Show();
               

            }
            else
            {
                txtKul.BackColor = Color.Red;
                txtPass.BackColor = Color.Red;
                lbl12.Text = "Kullanıcı adı veya Şifre Yanlış";
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl12.BackColor = Color.Transparent;
        }

        private void txtKul_MouseEnter(object sender, EventArgs e)
        {
            txtKul.Clear();
        }

        private void txtPass_MouseEnter(object sender, EventArgs e)
        {
            txtPass.Clear();
        }
    }
}
