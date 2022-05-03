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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=otel;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        void OdaSayisi()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*) as a FROM odalar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtToplamOda.Text = dr["a"].ToString();
            }
            con.Close();
        }

        void DoluOda()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*) as a FROM odalar WHERE oda_durumu=1";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtDoluOda.Text = dr["a"].ToString();
            }
            con.Close();
        }

        void BosOda()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*) as a FROM odalar WHERE oda_durumu=0";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtBosOda.Text = dr["a"].ToString();
            }
            con.Close();
        }
        
        void YillikkMisafirAdet()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*) as a FROM misafirler WHERE giris_tarihi > DATEADD(YEAR,-1,GETDATE())";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMisafir.Text = dr["a"].ToString();
            }
            con.Close();
        }

        void OdaFiyat()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT avg(oda_ucreti) as a FROM odalar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtOdaFiyat.Text = dr["a"].ToString() + " TL";
            }
            con.Close();
        }

        void YillikGelir()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT sum(oda_ucreti) as a FROM misafirler,odalar WHERE giris_tarihi > DATEADD(YEAR,-1,GETDATE()) AND odalar.oda_no=misafirler.oda_no";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtGelir.Text = dr["a"].ToString() + " TL";
            }
            con.Close();
        }

        void CalisanSayisi()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*) as a FROM calisanlar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCalisanSayisi.Text = dr["a"].ToString();
            }
            con.Close();
        }

        void CalisanMaas()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT AVG(maas) as a FROM calisanlar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtOrtMaas.Text = dr["a"].ToString() + " TL";
            }
            con.Close();
        }
        void OrtalamaMaas()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(maas) as a FROM calisanlar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtToplamMaas.Text = dr["a"].ToString() + " TL";
            }
            con.Close();
        }

        void OrtalamaYas()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT avg(yas) as a FROM calisanlar";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtOrtYas.Text = dr["a"].ToString();
            }
            con.Close();
        }
        private void Istatistikler_Load(object sender, EventArgs e)
        {
            OdaSayisi();
            DoluOda();
            BosOda();
            YillikkMisafirAdet();
            OdaFiyat();
            YillikGelir();
            CalisanSayisi();
            CalisanMaas();
            OrtalamaMaas();
            OrtalamaYas();
        }

        
    }
}
