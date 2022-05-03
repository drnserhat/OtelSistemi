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
    public partial class KayitEkleme : Form
    {
        public KayitEkleme()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=otel;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataSet ds = new DataSet();

        void cbOdaSirala()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM odalar WHERE oda_durumu=0";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbOdalar.Items.Add(dr["oda_no"]);
                cbOda1.Items.Add(dr["oda_no"]);
            }
            con.Close();
        }
        void odaListele()
        {
            
            da = new SqlDataAdapter("SELECT oda_no,oda_ucreti,oda_standart,IIF(oda_durumu=0,'BOS','DOLU') as durum FROM odalar WHERE oda_durumu=0",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "odalar");
            dgwOdalar.DataSource = ds.Tables["odalar"];

            con.Close();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd.Connection = con;
            if (rbErkek.Checked==true)
            {
                cmd.CommandText = "INSERT INTO misafirler(misafir_adi,misafir_soyadi,telefon,cinsiyet,giris_tarihi,cikis_tarihi,oda_no) VALUES('" + txtAD.Text + "','" + txtSOYAD.Text + "','" + txtTel.Text + "',0,GETDATE(),'" + txtCikisTarihi.Text + "','" + cbOdalar.Text + "')";
            }
            if (rbKadin.Checked==true)
            {
                cmd.CommandText = "INSERT INTO misafirler(misafir_adi,misafir_soyadi,telefon,cinsiyet,giris_tarihi,cikis_tarihi,oda_no) VALUES('" + txtAD.Text + "','" + txtSOYAD.Text + "','" + txtTel.Text + "',1,GETDATE(),'" + txtCikisTarihi.Text + "','" + cbOdalar.Text + "')";

            }
            cmd.ExecuteNonQuery();
            if (txtAD.Text == "" && txtSOYAD.Text == "" && txtTel.Text == "" && (rbErkek.Checked ==false|| rbKadin.Checked==false) && txtCikisTarihi.Text == "" &&cbOdalar.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı.");

                cmd.CommandText = "UPDATE odalar SET oda_durumu=1 WHERE oda_no='"+cbOdalar.Text+"'";

                cmd.ExecuteNonQuery();
                
            }
            con.Close();
            odaListele();
            cbOdaSirala();
            
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            odaListele();
            cbOdaSirala();
        }

        private void txtCikisTarihi_MouseHover(object sender, EventArgs e)
        {
            txtCikisTarihi.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd.Connection = con;
            if (rbErkek.Checked == true)
            {
                cmd.CommandText = "INSERT INTO misafirler(misafir_adi,misafir_soyadi,telefon,cinsiyet,giris_tarihi,cikis_tarihi,oda_no) VALUES('" + txtAD1.Text + "','" + txtSoyad1.Text + "','" + txtTel1.Text + "',0,'"+txtGirisTarihi.Text+"','" + txtCikisTarihi1.Text + "','" + cbOda1.Text + "')";
            }
            if (rbKadin.Checked == true)
            {
                cmd.CommandText = "INSERT INTO misafirler(misafir_adi,misafir_soyadi,telefon,cinsiyet,giris_tarihi,cikis_tarihi,oda_no) VALUES('" + txtAD1.Text + "','" + txtSoyad1.Text + "','" + txtTel1.Text + "',1,'" + txtGirisTarihi.Text + "','" + txtCikisTarihi1.Text + "','" + cbOda1.Text + "')";

            }
            cmd.ExecuteNonQuery();
            if (txtAD1.Text == "" && txtSoyad1.Text == "" && txtTel1.Text == "" && (rbErkek1.Checked == false || rbKadin1.Checked == false) && txtCikisTarihi1.Text == "" && cbOda1.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            }
            else
            {
                MessageBox.Show("Rezervasyon Başarılı.");
                cmd.CommandText = "UPDATE odalar SET oda_durumu=1 WHERE oda_no='" + cbOdalar.Text + "'";
                cmd.ExecuteNonQuery();

            }
            con.Close();
            odaListele();
            cbOdaSirala();
        }

        private void txtGirisTarihi_MouseHover(object sender, EventArgs e)
        {
            txtGirisTarihi.Clear();
        }
    }
}
