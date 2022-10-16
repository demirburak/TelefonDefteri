using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.KisiIsKatmani
{
    public class KisiYoneticisi
    {
        public string KisiKaydet(string adiSoyadi, string adres,
            string isyeri, string unvan, string aciklama, int grupId)
        {
            string sonuc = "";

            //Parametreler verileri doğrualamar yapılacak.
            KisiVeriDogrulama kisiVeriDogrulama = new KisiVeriDogrulama();
            sonuc = kisiVeriDogrulama.VeriDogrula(adiSoyadi, adres, isyeri, unvan,
                 aciklama, grupId);

            if (sonuc != "") return sonuc;

            Kisi kisi = new Kisi();
            kisi.AdiSoyadi = adiSoyadi;
            kisi.Aciklama = aciklama;
            kisi.Adres = adres;
            kisi.GrupId = grupId;
            kisi.Isyeri = isyeri.ToUpper();
            kisi.Unvan = unvan;

            //Parametrelere kurallar uygulanacak.
            KisiKurallari kisiKurallari = new KisiKurallari();
            sonuc = kisiKurallari.KuralKontrolEt(kisi);

            if (sonuc != "") return sonuc;

            //Kaydedebilirsin.
            KisiVeriErisimi kisiVeriErisimi = new KisiVeriErisimi();
            sonuc = kisiVeriErisimi.Kaydet(kisi);

            sonuc = (sonuc == "") ? "Kayıt edildi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        
        public List<Kisi> KisiListesiGetir(string aranan)
        {
            KisiVeriErisimi kisiVeriErisimi = new KisiVeriErisimi();
            List<Kisi> kisiListesi = kisiVeriErisimi.KisiListesiGetir(aranan);
            return kisiListesi;
        }

        public Kisi KisiGetir(int kisiId)
        {
            KisiVeriErisimi kisiVeriErisimi = new KisiVeriErisimi();
            Kisi kisi = kisiVeriErisimi.KisiGetir(kisiId);
            return kisi;
        }

    }
}
