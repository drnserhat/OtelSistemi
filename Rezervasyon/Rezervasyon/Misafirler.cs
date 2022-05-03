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
    public partial class Misafirler : Form
    {
        public Misafirler()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=otel;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        void listele()
        {
            da = new SqlDataAdapter("SELECT misafir_id,misafir_adi,misafir_soyadi,telefon,IIF(cinsiyet=0,'ERKEK','KADIN') AS cinsiyet,giris_tarihi,cikis_tarihi,oda_no FROM misafirler ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "misafirler");
            dataGridView1.DataSource = ds.Tables["misafirler"];

            con.Close();
        }
        private void btnARA_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Metinin içi boş");
            }
            else
            {
                da = new SqlDataAdapter("SELECT * FROM misafirler where misafir_adi like '" + textBox1.Text + "%'", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "misafirler");
                dataGridView1.DataSource = ds.Tables["misafirler"];

                con.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM misafirler WHERE misafir_id='" + lblsil.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            listele();


        }

        private void Misafirler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblsil.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
