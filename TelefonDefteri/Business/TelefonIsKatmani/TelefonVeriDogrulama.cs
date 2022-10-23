namespace TelefonDefteri.Business.TelefonIsKatmani
{
    public class TelefonVeriDogrulama
    {
        public string VeriDogrula(string telefonNumarasi, string tur, int kisiId)
        {
            string sonuc = "";

            if (string.IsNullOrEmpty(telefonNumarasi)) sonuc = "Telefon numarası boş olamaz";
            if (string.IsNullOrEmpty(tur)) sonuc = "Tür alanı boş olamaz";
            if (kisiId == 0) sonuc = "Kişi Id sıfır olamaz";

            return sonuc;
        }
    }
}
