using System.Data.SqlClient;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Business.KisiIsKatmani;

namespace TelefonDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void Temizle()
        {
            /* temizlik kodlarý yazýlýr
             *   
             *   
             *   
             */
        }

        private void btnSil_Click(object sender, EventArgs e)
        {




            Temizle();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            KisiYoneticisi kisiYoneticisi = new();
            int grupId = (int)cmbGrup.SelectedValue;

            string sonuc = kisiYoneticisi.KisiKaydet(
                txtAdiSoyadi.Text, txtAdres.Text,
                txtIsyeri.Text, txtUnvan.Text, txtAciklama.Text
                , grupId);

            MessageBox.Show(sonuc);

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }
    }
}