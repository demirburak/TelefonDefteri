using System.Data;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.KisiIsKatmani
{
    public class KisiKurallari
    {
        public string KuralKontrolEt(Kisi kisi)
        {
            string sonuc = "";

            if (AyniKisidenVarmi(kisi.AdiSoyadi)) sonuc = "Aynı isimden farklı bir kayıt bulunmaktadır.";

            return sonuc;
        }

        public bool AyniKisidenVarmi(string adiSoyadi)
        {
            bool varmi = false;

            string sorgu = $" SELECT * FROM Kisiler WHERE UPPER(AdiSoyadi)='{adiSoyadi.ToUpper()}' ";
            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            DataTable dtSonuc = vtBaglantisi.VeriGetir(sorgu);
            if (dtSonuc.Rows.Count > 0)
            {
                varmi = true;
            }

            return varmi;
        }

    }
}
