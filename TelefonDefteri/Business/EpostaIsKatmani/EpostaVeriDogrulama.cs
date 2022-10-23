namespace EpostaDefteri.Business.EpostaIsKatmani
{
    public class EpostaVeriDogrulama
    {
        public string VeriDogrula(string epostaAdresi, string tur, int kisiId)
        {
            string sonuc = "";

            if (string.IsNullOrEmpty(epostaAdresi)) sonuc = "Eposta adresi boş olamaz";
            if (string.IsNullOrEmpty(tur)) sonuc = "Tür alanı boş olamaz";
            if (kisiId == 0) sonuc = "Kişi Id sıfır olamaz";

            return sonuc;
        }
    }
}
