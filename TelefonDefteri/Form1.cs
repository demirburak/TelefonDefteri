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
            dgvListe.Columns.Add("KisiId", "Kiþi Referans");
            dgvListe.Columns["KisiId"].Visible = false;
            dgvListe.Columns.Add("AdiSoyadi", "Adý Soyadý");
            Temizle();
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
            lblid.Text = "";
            pbProfil.Image = null;
            txtAdiSoyadi.Text = "";
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtIsyeri.Text = "";
            txtUnvan.Text = "";
            lvEpostalar.Items.Clear();
            lvTelefonlar.Items.Clear();
            if (cmbGrup.Items.Count > 0) cmbGrup.SelectedIndex = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {




            Temizle();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            KisiYoneticisi kisiYoneticisi = new();
            int grupId = (int)cmbGrup.SelectedValue;

            string sonuc = "";
            bool basarilimi = false;
            if (lblid.Text == "") //Yeni Kayýt
            {
                sonuc = kisiYoneticisi.KisiKaydet(
                    txtAdiSoyadi.Text, txtAdres.Text,
                    txtIsyeri.Text, txtUnvan.Text, txtAciklama.Text
                    , grupId);
                if (sonuc == "Kayýt edildi") basarilimi = true;
            }
            else //Güncelleme
            {
                int kisiId = int.Parse(lblid.Text);

                sonuc = kisiYoneticisi.KisiGuncelle(
                   txtAdiSoyadi.Text, txtAdres.Text,
                   txtIsyeri.Text, txtUnvan.Text, txtAciklama.Text
                   , grupId,kisiId);
                if (sonuc == "Güncellendi") basarilimi = true;
            }

            MessageBox.Show(sonuc);
            if (basarilimi) Temizle();
            KisiListesiGetir();
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KisiListesiGetir();
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

        private void KisiListesiGetir()
        {
            KisiYoneticisi kisiYoneticisi = new KisiYoneticisi();
            List<Kisi> kisiListesi = kisiYoneticisi.KisiListesiGetir(txtAra.Text);

            dgvListe.Rows.Clear();
            foreach (var kisi in kisiListesi)
            {
                dgvListe.Rows.Add(kisi.KisiId, kisi.AdiSoyadi);
            }
        }

        private void KisiGetir(int satirIndeks)
        {
            KisiYoneticisi kisiYoneticisi = new KisiYoneticisi();
            int kisiId = Convert.ToInt32(dgvListe.Rows[satirIndeks].Cells["KisiId"].Value.ToString());
            Kisi kisi = kisiYoneticisi.KisiGetir(kisiId);
            Temizle();

            lblid.Text = kisiId.ToString();
            pbProfil.Image = kisi.ProfilResmi;
            txtAdiSoyadi.Text = kisi.AdiSoyadi;
            txtAciklama.Text = kisi.Aciklama;
            txtAdres.Text = kisi.Adres;
            txtIsyeri.Text = kisi.Isyeri;
            txtUnvan.Text = kisi.Unvan;
            cmbGrup.SelectedValue = kisi.GrupId;
        
            //lvEpostalar.Items.Clear();
            //lvTelefonlar.Items.Clear();
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KisiGetir(e.RowIndex);
        }
    }
}