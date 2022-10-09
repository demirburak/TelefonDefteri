using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri.Business.KisiIsKatmani
{
    public class KisiVeriDogrulama
    {
        public string VeriDogrula(string adiSoyadi, string adres,
            string isyeri, string unvan, string aciklama, int grupId)
        {
            string sonuc = "";

            if (string.IsNullOrEmpty(adiSoyadi)) sonuc = "Adı soyadı boş olamaz.";
            if (adiSoyadi.Length > 50) sonuc = "Adı soyadı 50 karakterden büyük olamaz.";
            if (isyeri.Length > 50) sonuc = "İşyeri 50 karakterden büyük olamaz.";
            if (unvan.Length > 50) sonuc = "Ünvan 50 karakterden büyük olamaz.";
            if (grupId == 0) sonuc = "Grup seçimi yapılmamış.";

            

            return sonuc;
        }
    }
}
