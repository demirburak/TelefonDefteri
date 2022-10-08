using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.Business.KisiIsKatmani;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.GrupIsKatmani
{
    public class GrupYoneticisi
    {
        public string GrupKaydet(string grupAdi, string aciklama)
        {
            string sonuc = "";

            //Parametreler verileri doğrualamar yapılacak.
            GrupVeriDogrulama grupVeriDogrulama = new GrupVeriDogrulama();
            sonuc = grupVeriDogrulama.VeriDogrula(grupAdi, aciklama);

            if (sonuc != "") return sonuc;

            Grup grup = new Grup();
            grup.Aciklama = aciklama;
            grup.GrupAdi = grupAdi.ToUpper();

            //Parametrelere kurallar uygulanacak.
            GrupKurallari grupKurallari = new GrupKurallari();
            sonuc = grupKurallari.KuralKontrolEt(grup);

            if (sonuc != "") return sonuc;

            //Kaydedebilirsin.
            GrupVeriErisimi grupVeriErisimi = new GrupVeriErisimi();
            sonuc = grupVeriErisimi.Kaydet(grup);

            sonuc = (sonuc == "") ? "Kayıt edildi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public string GrupSil(int grupId)
        {
            string sonuc = "";

            //Kural Kontrolü
            GrupKurallari grupKurallari = new GrupKurallari();
            sonuc = grupKurallari.SilmeIslemindenOnceKuralKontrolEt(grupId);
            if (sonuc != "") return sonuc;

            //Veri erişiminden silme işlemini yap.
            GrupVeriErisimi grupVeriErisimi = new GrupVeriErisimi();
            Grup grup = grupVeriErisimi.GrupGetir(grupId);
            sonuc = grupVeriErisimi.Sil(grup);

            sonuc = (sonuc == "") ? "Kayıt silindi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public List<Grup> GrupListesiGetir()
        {
            List<Grup> liste = new List<Grup>();

            GrupVeriErisimi grupVeriErisimi = new GrupVeriErisimi();
            liste = grupVeriErisimi.GrupListesiGetir("");

            return liste;
        }



    }
}
