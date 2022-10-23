using EpostaDefteri.Business.EpostaIsKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonDefteri.Business.GrupIsKatmani;
using TelefonDefteri.Business.TelefonIsKatmani;

namespace TelefonDefteri
{
    public partial class EklemeFormu : Form
    {
        string PencereTuru = "";
        int KisiId = 0;

        public EklemeFormu(string pencereTuru, int kisiId)
        {
            InitializeComponent();
            PencereTuru = pencereTuru;
            KisiId = kisiId;
        }

        private void EklemeFormu_Load(object sender, EventArgs e)
        {
            //Pencere kontrolü
            string kontrolSonucu = PencereTuruKontrolEt();
            if (!string.IsNullOrEmpty(kontrolSonucu))
            {
                MessageBox.Show(kontrolSonucu);
                this.Close();
            }

            //Ekran Düzelt
            EkranBilgileriniDuzenle();
        }

        private string PencereTuruKontrolEt()
        {
            if (PencereTuru == "Grup" || PencereTuru == "Eposta" || PencereTuru == "Telefon")
            {
                return "";
            }
            else
            {
                return "Hatalı pencere türü yazdınız.";
            }
        }

        private void EkranBilgileriniDuzenle()
        {
            if (PencereTuru == "Grup")
            {
                lblTur.Text = "Grup Adı";
                lblEpostaTelefonGrup.Text = "Açıklama";
            }
            else if (PencereTuru == "Eposta")
            {
                lblEpostaTelefonGrup.Text = "Eposta Adresi";
            }
            else if (PencereTuru == "Telefon")
            {
                lblEpostaTelefonGrup.Text = "Telefon Numarası";
            }
        }

        private void btnEpostaTelefonGrupEkle_Click(object sender, EventArgs e)
        {
            string sonuc = "";

            if (PencereTuru == "Grup")
            {
                GrupYoneticisi grupYoneticisi = new GrupYoneticisi();
                sonuc = grupYoneticisi.GrupKaydet(txtTur.Text, txtEpostaTelefonGrup.Text);
            }
            else if (PencereTuru == "Eposta")
            {
                EpostaYoneticisi epostaYoneticisi = new EpostaYoneticisi();
                sonuc = epostaYoneticisi.EpostaEkle(txtEpostaTelefonGrup.Text, txtTur.Text, KisiId);
            }
            else if (PencereTuru == "Telefon")
            {
                TelefonYoneticisi telefonYoneticisi = new TelefonYoneticisi();
                sonuc = telefonYoneticisi.TelefonEkle(txtEpostaTelefonGrup.Text, txtTur.Text, KisiId);
            }

            MessageBox.Show(sonuc);

        }
    }
}
