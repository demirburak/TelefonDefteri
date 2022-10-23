using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.TelefonIsKatmani
{
    public class TelefonYoneticisi
    {
        public string TelefonEkle(string telefonNumarasi, string tur, int kisiId)
        {
            string sonuc = "";

            //Veri doğrulama
            TelefonVeriDogrulama telefonVeriDogrulama = new TelefonVeriDogrulama();
            sonuc = telefonVeriDogrulama.VeriDogrula(telefonNumarasi, tur, kisiId);
            if (sonuc != "") return sonuc;

            //Nesneyi oluşturalım
            Telefon telefon = new Telefon();
            telefon.KisiId = kisiId;
            telefon.TelefonNumarasi = telefonNumarasi;
            telefon.Tur = tur.ToUpper();

            //Kuralları çalıştıralım
            TelefonKurallari telefonKurallari = new TelefonKurallari();
            sonuc = telefonKurallari.KuralKontrolEt(telefon);
            if (sonuc != "") return sonuc;

            //Ekleme işlemi yapalım
            TelefonVeriErisimi telefonVeriErisimi = new TelefonVeriErisimi();
            sonuc = telefonVeriErisimi.Kaydet(telefon);
            sonuc = (sonuc == "") ? "Kayıt edildi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public string TelefonCikar(int telefonId)
        {
            string sonuc = "";

            TelefonVeriErisimi telefonVeriErisimi = new TelefonVeriErisimi();
            Telefon telefon = telefonVeriErisimi.TelefonGetir(telefonId);
            sonuc = telefonVeriErisimi.Sil(telefon);
            sonuc = (sonuc == "") ? "Silindi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public List<Telefon> TelefonListesiGetir(int kisiId)
        {
            List<Telefon> liste = new List<Telefon>();

            TelefonVeriErisimi telefonVeriErisimi = new TelefonVeriErisimi();
            liste = telefonVeriErisimi.TelefonListesiGetir(kisiId);

            return liste;
        }
        

    }
}
