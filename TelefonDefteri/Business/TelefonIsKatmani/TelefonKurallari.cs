using System.Data;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.TelefonIsKatmani
{
    public class TelefonKurallari
    {
        public string KuralKontrolEt(Telefon telefon)
        {
            string sonuc = "";

            if (TelefonNumarasiFarkliKisideKullanilmismi(telefon.TelefonNumarasi, telefon.KisiId)) sonuc = "Telefon numarası farklı kişide kullanılıyor";

            return sonuc;
        }

        private bool TelefonNumarasiFarkliKisideKullanilmismi(string telefonNumarasi, int kisiId)
        {
            bool sonuc = false;

            string sorgu = $"SELECT * FROM Telefonlar WHERE TelefonNumarasi='{telefonNumarasi}' AND KisiId<>{kisiId} ";
            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);
            if (dt.Rows.Count > 0) sonuc = true;

            return sonuc;
        }
    }
}
