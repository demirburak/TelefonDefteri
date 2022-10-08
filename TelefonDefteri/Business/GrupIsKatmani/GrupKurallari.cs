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

        private bool AyniGruptanVarmi(string grupAdi)
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
        
        public string SilmeIslemindenOnceKuralKontrolEt(int grupId)
        {
            string sonuc = "";

            if (GrubuKullananKisiVarmi(grupId)) sonuc = "Bu grubu kullanan kişi(ler) bulunmaktadır.";

            return sonuc;
        }

        private bool GrubuKullananKisiVarmi(int grupId)
        {
            bool varmi = false;

            string sorgu = $"SELECT * FROM Kisiler WHERE GrupId={grupId}";
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
