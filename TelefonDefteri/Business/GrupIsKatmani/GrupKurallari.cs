using System.Data;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.GrupIsKatmani
{
    public class GrupKurallari
    {
        public string KuralKontrolEt(Grup grup)
        {
            string sonuc = "";

            if (AyniGruptanVarmi(grup.GrupAdi)) sonuc = "Aynı isimden farklı bir kayıt bulunmaktadır.";

            return sonuc;
        }

        public bool AyniGruptanVarmi(string grupAdi)
        {
            bool varmi = false;

            string sorgu = $" SELECT * FROM Gruplar WHERE GrupAdi='{grupAdi.ToUpper()}' ";
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
