using System.Data;
using TelefonDefteri.Models;

namespace TelefonDefteri.DataAccess
{
    public class EpostaVeriErisimi
    {
        //Kaydet,Güncelle,Sil,kisigetir,list ve datadönüştür tamamlandı
        public string Kaydet(Eposta eposta)
        {
            string sonuc = "";

            string sorgu = "INSERT INTO Epostalar" +
               "(EpostaAdresi,Tur,KisiId)" +
               " VALUES " +
               $"('{eposta.EpostaAdresi}','{eposta.Tur}',{eposta.KisiId})";


            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Ekleme işlemi başarısız.";
            }
            return sonuc;
        }
        public string Guncelle(Eposta eposta)
        {
            string sonuc = "";

            string sorgu = "UPDATE Epostalar" +
           " SET " +
            $" EpostaAdresi = '{eposta.EpostaAdresi}'," +
            $" Tur= '{eposta.Tur}'," +
            $" KisiId = {eposta.KisiId}" +
            $" WHERE EpostaId = {eposta.EpostaId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Güncelleme işlemi başarısız.";
            }

            return sonuc;
        }
        public string Sil(Eposta eposta)
        {
            string sonuc = "";

            string sorgu = $"DELETE FROM Epostalar WHERE EpostaId = {eposta.EpostaId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Silme işlemi başarısız.";
            }

            return sonuc;
        }
        public Eposta EpostaGetir(int epostaId)
        {
            Eposta eposta = new();

            string sorgu = $"SELECT * FROM dbo.Epostalar WHERE EpostaId={epostaId}";
            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                eposta = DonusturDataRowdanEpostaya(dr);

            }

            return eposta;
        }
        public List<Eposta> EpostaListesiGetir(string aranan)
        {
            List<Eposta> epostalar = new();

            string sorgu = "SELECT * FROM Epostalar" +
                       $" WHERE EpostaAdresi LIKE '%{aranan}%' " +
                       $" OR Tur LIKE '%{aranan}%' " +
                       $" ORDER BY EpostaAdresi ";



            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Eposta eposta = new();
                    eposta = DonusturDataRowdanEpostaya(dr);
                    epostalar.Add(eposta);
                }
            }
            return epostalar;
        }
        public List<Eposta> EpostaListesiGetir(int kisiId)
        {
            List<Eposta> epostalar = new();

            string sorgu = "SELECT * FROM Epostalar" +
                       $" WHERE " +
                       $" KisiId = {kisiId} ";



            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Eposta eposta = new();
                    eposta = DonusturDataRowdanEpostaya(dr);
                    epostalar.Add(eposta);
                }
            }
            return epostalar;
        }
        private Eposta DonusturDataRowdanEpostaya(DataRow dr)
        {
            Eposta eposta = new Eposta();

            eposta.EpostaId = Convert.ToInt32(dr["EpostaId"].ToString());
            eposta.KisiId = Convert.ToInt32(dr["KisiId"].ToString());
            eposta.Tur = dr["Tur"].ToString();
            eposta.EpostaAdresi = dr["EpostaAdresi"].ToString();

            return eposta;
        }
    }

}