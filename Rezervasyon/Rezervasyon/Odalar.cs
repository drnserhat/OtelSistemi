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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=otel;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        void cbOdaSirala()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM odalar";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbOdalar.Items.Add(dr["oda_no"]);
            }
            con.Close();
        }
        private void btnOda_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT oda_no,oda_standart,oda_ucreti,IIF(oda_durumu=1,'DOLU','BOS') AS durum FROM odalar where oda_no='" + cbOdalar.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blblOdaNo.Text = dr["oda_no"].ToString();
                lblDurum.Text = dr["durum"].ToString();
                lblStandart.Text = dr["oda_standart"].ToString();
                lblUcret.Text = dr["oda_ucreti"].ToString() + "TL";
              
               

            }
            con.Close();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            cbOdaSirala();
            
        }

        private int imageno = 0;
        private void loadImage()
        {
            if (imageno==3)
            {
                imageno = 0;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\excalibur\Desktop\C#\CALISMA\Rezervasyon\Rezervasyon\img\slider\{0}.png", imageno);
            imageno++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImage();
        }
    }
}
