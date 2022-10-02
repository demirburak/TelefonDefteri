namespace TelefonDefteri.Business.GrupIsKatmani
{
    public class GrupVeriDogrulama
    {
        public string VeriDogrula(string grupAdi, string aciklama)
        {
            string sonuc = "";

            if (string.IsNullOrEmpty(grupAdi)) sonuc = "Grup adı boş olamaz.";
            if (string.IsNullOrEmpty(aciklama)) sonuc = "Açıklama boş olamaz.";
            if (grupAdi.Length > 50) sonuc = "Grup adı 50 karakterden büyük olamaz.";

            if (!string.IsNullOrEmpty(grupAdi)) grupAdi = grupAdi.ToUpper();

            return sonuc;
        }
    }
}
