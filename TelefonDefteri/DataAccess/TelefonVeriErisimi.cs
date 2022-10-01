using System.Data;
using TelefonDefteri.Models;

namespace TelefonDefteri.DataAccess
{
    public class TelefonVeriErisimi
    {
        //Kaydet,Güncelle,Sil,kisigetir,list ve datadönüştür tamamlandı
        public string Kaydet(Telefon telefon)
        {
            string sonuc = "";

            string sorgu = "INSERT INTO Telefonlar" +
               "(TelefonId,TelefonNumarasi,Tur,KisiID)" +
               " VALUES " +
               $"({telefon.TelefonId},'{telefon.TelefonNumarasi}','{telefon.Tur}',{telefon.KisiId})";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Ekleme işlemi başarısız.";
            }

            return sonuc;
        }
        public string Guncelle(Telefon telefon)
        {
            string sonuc = "";

            string sorgu = "UPDATE Telefonlar" +
           " SET " +
            $" TelefonNumarası = '{telefon.TelefonNumarasi}'," +
            $" Tur= '{telefon.Tur}'," +
            $" KisiID = {telefon.KisiId}" +
            $" WHERE TelefonID = {telefon.TelefonId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Güncelleme işlemi başarısız.";
            }
            return sonuc;
        }
        public string Sil(Telefon telefon)
        {
            string sonuc = "";

            string sorgu = $"DELETE FROM Telefonlar WHERE TelefonID = {telefon.TelefonId}";

            VtBaglantisi vtBaglantisi = new();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);
            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Silme işlemi başarısız.";
            }

            return sonuc;
        }
        public Telefon TelefonGetir(int telefonId)
        {
            Telefon telefon = new();

            string sorgu = $"SELECT * FROM dbo.Telefonlar WHERE TelefonId={telefonId}";
            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                telefon = DonusturDataRowdanTelefona(dr);

            }

            return telefon;
        }
        public List<Telefon> TelefonListesiGetir(string aranan)
        {
            List<Telefon> telefonlar = new();

            string sorgu = "SELECT * FROM Telefonlar " +
                      $" WHERE " +
                      $" TelefonNumarasi LIKE '%{aranan}%' " +
                      $" OR Tur LIKE '%{aranan}%' ";


            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Telefon telefon = new();
                    telefon = DonusturDataRowdanTelefona(dr);
                    telefonlar.Add(telefon);
                }
            }

            return telefonlar;
        }
        private Telefon DonusturDataRowdanTelefona(DataRow dr)
        {
            Telefon telefon = new Telefon();

            telefon.KisiId = Convert.ToInt32(dr["KisiID"].ToString());
            telefon.TelefonId = Convert.ToInt32(dr["TelefonID"].ToString());
            telefon.Tur = dr["Tur"].ToString();
            telefon.TelefonNumarasi = (dr.IsNull("TelefonNumarasi")) ? "" : dr["TelefonNumarasi"].ToString();

            return telefon;
        }
    }
}