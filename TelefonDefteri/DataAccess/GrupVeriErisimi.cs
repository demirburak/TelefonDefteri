using System.Data;
using TelefonDefteri.Models;

namespace TelefonDefteri.DataAccess
{
    public class GrupVeriErisimi
    {
        //Kaydet,Güncelle,Sil,kisigetir,list ve datadönüştür tamamlandı
        public string Kaydet(Grup grup)
        {
            string sonuc = "";


            string sorgu = "INSERT INTO Gruplar" +
                "(GrupId,GrupAdi,Aciklama)" +
                " VALUES " +
                $"({grup.GrupId},'{grup.GrupAdi}','{grup.Aciklama}')";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Ekleme işlemi başarısız.";
            }

            return sonuc;
        }
        public string Guncelle(Grup grup)
        {
            string sonuc = "";

            string sorgu = "UPDATE Gruplar" +
           " SET " +
            $" GrupAdi = '{grup.GrupAdi}'," +
            $" Aciklama = '{grup.Aciklama}' " +
            $" WHERE GrupId = {grup.GrupId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Güncelleme işlemi başarısız.";
            }

            return sonuc;
        }
        public string Sil(Grup grup)
        {
            string sonuc = "";

            string sorgu = $"DELETE FROM Gruplar WHERE GrupId = {grup.GrupId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Silme işlemi başarısız.";
            }

            return sonuc;
        }
        public Grup GrupGetir(int grupId)
        {
            Grup grup = new();

            string sorgu = $"SELECT * FROM dbo.Gruplar WHERE GrupId={grupId}";
            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                grup = DonusturDataRowdanGruba(dr);

            }

            return grup;
        }
        public List<Grup> GrupListesiGetir(string aranan)
        {
            List<Grup> gruplar = new();


            string sorgu = "SELECT * FROM Gruplar" +
                       $" WHERE  " +
                       $" OR GrupAdi LIKE '%{aranan}%' " +
                       $" OR Aciklama LIKE '%{aranan}%' ";

            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Grup grup = new();
                    grup = DonusturDataRowdanGruba(dr);
                    gruplar.Add(grup);
                }
            }

            return gruplar;
        }
        private Grup DonusturDataRowdanGruba(DataRow dr)
        {
            Grup grup = new Grup();

            grup.GrupId = Convert.ToInt32(dr["GrupId"].ToString());
            grup.GrupAdi = (dr.IsNull("GrupAdi")) ? "" : dr["GrupAdi"].ToString();
            grup.Aciklama = (dr.IsNull("Aciklama")) ? "" : dr["Aciklama"].ToString();
            return grup;
        }
    }
}
