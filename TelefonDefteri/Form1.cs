using System.Data.SqlClient;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Business.KisiIsKatmani;
using TelefonDefteri.Business.GrupIsKatmani;

namespace TelefonDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GruplariYukle();
        }

        private void GruplariYukle()
        {
            GrupYoneticisi grupYoneticisi = new GrupYoneticisi();
            cmbGrup.DataSource = grupYoneticisi.GrupListesiGetir();
            cmbGrup.DisplayMember = "GrupAdi";
            cmbGrup.ValueMember = "GrupId";
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

        private void btnGrupEkle_Click(object sender, EventArgs e)
        {
            EklemeFormu eklemeFormu = new EklemeFormu("Grup");
            eklemeFormu.ShowDialog();
            GruplariYukle();
        }

        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            EklemeFormu eklemeFormu = new EklemeFormu("Telefon");
            eklemeFormu.ShowDialog();
        }

        private void btnEpostaEkle_Click(object sender, EventArgs e)
        {
            EklemeFormu eklemeFormu = new EklemeFormu("Eposta");
            eklemeFormu.ShowDialog();
        }

        private void btnGrupCikar_Click(object sender, EventArgs e)
        {
            int grupId = (cmbGrup.SelectedItem != null) ? (int)cmbGrup.SelectedValue : 0;
            GrupYoneticisi grupYoneticisi = new GrupYoneticisi();
            string sonuc = grupYoneticisi.GrupSil(grupId);
            MessageBox.Show(sonuc);
            GruplariYukle();

        }
    }
}