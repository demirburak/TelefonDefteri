using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonDefteri
{
    public partial class EklemeFormu : Form
    {
        string PencereTuru = "";

        public EklemeFormu(string pencereTuru)
        {
            InitializeComponent();
            PencereTuru = pencereTuru;
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

    }
}
