using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace EpostaDefteri.Business.EpostaIsKatmani
{
    public class EpostaYoneticisi
    {
        public string EpostaEkle(string epostaAdresi, string tur, int kisiId)
        {
            string sonuc = "";

            //Veri doğrulama
            EpostaVeriDogrulama EpostaVeriDogrulama = new EpostaVeriDogrulama();
            sonuc = EpostaVeriDogrulama.VeriDogrula(epostaAdresi, tur, kisiId);
            if (sonuc != "") return sonuc;

            //Nesneyi oluşturalım
            Eposta Eposta = new Eposta();
            Eposta.KisiId = kisiId;
            Eposta.EpostaAdresi = epostaAdresi;
            Eposta.Tur = tur.ToUpper();

            //Kuralları çalıştıralım
            EpostaKurallari EpostaKurallari = new EpostaKurallari();
            sonuc = EpostaKurallari.KuralKontrolEt(Eposta);
            if (sonuc != "") return sonuc;

            //Ekleme işlemi yapalım
            EpostaVeriErisimi EpostaVeriErisimi = new EpostaVeriErisimi();
            sonuc = EpostaVeriErisimi.Kaydet(Eposta);
            sonuc = (sonuc == "") ? "Kayıt edildi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public string EpostaCikar(int epostaId)
        {
            string sonuc = "";

            EpostaVeriErisimi EpostaVeriErisimi = new EpostaVeriErisimi();
            Eposta Eposta = EpostaVeriErisimi.EpostaGetir(epostaId);
            sonuc = EpostaVeriErisimi.Sil(Eposta);
            sonuc = (sonuc == "") ? "Silindi" : $"Hata : {sonuc} ";

            return sonuc;
        }

        public List<Eposta> EpostaListesiGetir(int kisiId)
        {
            List<Eposta> liste = new List<Eposta>();

            EpostaVeriErisimi EpostaVeriErisimi = new EpostaVeriErisimi();
            liste = EpostaVeriErisimi.EpostaListesiGetir(kisiId);

            return liste;
        }

    }
}
