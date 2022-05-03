using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar();
            oda.Show();
        }

        private void YoneticiEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMisafir_Click(object sender, EventArgs e)
        {
            Misafirler a = new Misafirler();
            a.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            KayitEkleme s = new KayitEkleme();
            s.Show();
        }

        private void btnIstatislik_Click(object sender, EventArgs e)
        {
            Istatistikler rapor = new Istatistikler();
            rapor.Show();
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            Calisanlar a = new Calisanlar();
            a.Show();
        }
    }
}
