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
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=otel;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        void CalisanListele()
        {
            da = new SqlDataAdapter("SELECT * FROM calisanlar",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "calisanlar");
            dataGridView1.DataSource = ds.Tables["calisanlar"];
            con.Close();
        }

        void gorevListele_Grid()
        {
            da = new SqlDataAdapter("SELECT * FROM gorevler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gorevler");
            dataGridView2.DataSource = ds.Tables["gorevler"];
            con.Close();
        }
        void gorevListele()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM gorevler";
            dr = cmd.ExecuteReader();
           while (dr.Read())
            {
                cbGorev.Items.Add(dr["gorev_id"]);
            }
            con.Close();
        }
        private void btnEKLE_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO calisanlar VALUES('" + txtAD.Text + "','" + txtSOYAD.Text + "','" + txtYAS.Text + "','" + txtTEL.Text + "','" + txtMAAS.Text + "','" + cbGorev.Text + "')";
            cmd.ExecuteNonQuery();
            if (txtAD.Text == "" || txtSOYAD.Text =="" || txtMAAS.Text=="" || txtTEL.Text=="" || txtYAS.Text=="" || cbGorev.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanlari Doldurunuz!!");
            }
            else
            {
                MessageBox.Show("Çalışan Kaydı Başarılı.");
               
            }
            con.Close();
            Temizle();
            CalisanListele();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            CalisanListele();
            gorevListele();
           
            gorevListele_Grid();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYAS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTEL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMAAS.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbGorev.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE calisanlar SET ad='"+txtAD+"',soyad='"+txtSOYAD+"',yas='"+txtYAS.Text+"',telefon='"+txtTEL.Text+"',maas='"+txtMAAS.Text+"', gorev_id='"+cbGorev.Text+"'";
            cmd.ExecuteNonQuery();
            if (txtAD.Text == "" || txtSOYAD.Text == "" || txtMAAS.Text == "" || txtTEL.Text == "" || txtYAS.Text == "" || cbGorev.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanlari Doldurunuz!!");
            }
            else
            {
                MessageBox.Show("Çalışan Kaydı Güncellendi.");
               
            }
            con.Close();
            Temizle();
            CalisanListele();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM calisanlar WHERE ad='" + txtAD.Text + "' AND soyad='" + txtSOYAD.Text + "' ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (txtAD.Text == "" || txtSOYAD.Text == "" || txtMAAS.Text == "" || txtTEL.Text == "" || txtYAS.Text == "" || cbGorev.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanlari Doldurunuz!!");
                }
                else
                {
                    MessageBox.Show("Çalışan Kaydı Silindi.");

                }
            }
            else
            {
                MessageBox.Show("AD ve Soyad ile eşleşen personel bulunmamaktadır.");
            }
            con.Close();
            Temizle();
            CalisanListele();
        }
        void Temizle()
        {
            txtAD.Clear();
            txtMAAS.Clear();
            txtSOYAD.Clear();
            txtTEL.Clear();
            txtYAS.Clear();
        }

        private void btnARA_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM calisanlar where ad like '" + txtARA.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];

            con.Close();
        }
    }
}
