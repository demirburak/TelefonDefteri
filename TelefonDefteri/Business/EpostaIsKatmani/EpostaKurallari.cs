using System.Data;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace EpostaDefteri.Business.EpostaIsKatmani
{
    public class EpostaKurallari
    {
        public string KuralKontrolEt(Eposta eposta)
        {
            string sonuc = "";

            if (EpostaAdresiFarkliKisideKullanilmismi(eposta.EpostaAdresi, eposta.KisiId)) sonuc = "Eposta numarası farklı kişide kullanılıyor";

            return sonuc;
        }

        private bool EpostaAdresiFarkliKisideKullanilmismi(string epostaAdresi, int kisiId)
        {
            bool sonuc = false;

            string sorgu = $"SELECT * FROM Epostalar WHERE EpostaAdresi='{epostaAdresi}' AND KisiId<>{kisiId} ";
            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);
            if (dt.Rows.Count > 0) sonuc = true;

            return sonuc;
        }
    }
}
