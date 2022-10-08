using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.Models;

namespace TelefonDefteri.DataAccess
{
    public class KisiVeriErisimi
    {
        public string Kaydet(Kisi kisi)
        {
            string sonuc = "";

            string sorgu = "INSERT INTO Kisiler " +
                " (AdiSoyadi,ProfilResmi,Adres,Isyeri,Unvan,GrupId,Aciklama)" +
                " VALUES " +
               $" ('{kisi.AdiSoyadi}',null,'{kisi.Adres}','{kisi.Isyeri}','{kisi.Unvan}'," +
               $"  {kisi.GrupId},'{kisi.Aciklama}' ) ";

            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);

            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Ekleme işlemi başarısız.";
            }

            return sonuc;
        }

        public string Guncelle(Kisi kisi)
        {
            string sonuc = "";

            string sorgu = "UPDATE Kisiler " +
                " SET " +
                    $" AdiSoyadi = '{kisi.AdiSoyadi}'," +
                    $" ProfilResmi = NULL," +
                    $" Adres = '{kisi.Adres}', " +
                    $" Isyeri = '{kisi.Isyeri}', " +
                    $" Unvan = '{kisi.Unvan}', " +
                    $" GrupId = {kisi.GrupId}, " +
                    $" Aciklama = '{kisi.Aciklama}' " +
                $" WHERE KisiId = {kisi.KisiId} ";

            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);

            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Güncelleme işlemi başarısız.";
            }

            return sonuc;
        }

        public string Sil(Kisi kisi)
        {
            string sonuc = "";

            string sorgu = $" DELETE FROM Kisiler WHERE KisiId = {kisi.KisiId} ";

            VtBaglantisi vtBaglantisi = new VtBaglantisi();
            int etkilenenSatirSayisi = vtBaglantisi.VeriGotur(sorgu);

            if (etkilenenSatirSayisi == 0)
            {
                sonuc = "Silme işlemi başarısız.";
            }

            Kisi eskiKisi = KisiGetir(5);

            return sonuc;
        }

        public Kisi KisiGetir(int kisiId)
        {
            Kisi kisi = new();

            string sorgu = $" SELECT * FROM Kisiler WHERE KisiId = {kisiId} ";

            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                kisi = DonusturDataRowdanKisiye(dr);
            }

            return kisi;
        }

        public List<Kisi> KisiListesiGetir(string aranan)
        {
            List<Kisi> kisiler = new();

            string sorgu = $"SELECT * FROM Kisiler WHERE " +
                $" AdiSoyadi LIKE '%{aranan}%' " +
                $" OR Adres LIKE '%{aranan}%' " +
                $" OR Isyeri LIKE '%{aranan}%' " +
                $" OR Unvan LIKE '%{aranan}%' " +
                $" OR Aciklama LIKE '%{aranan}%' " +
                $" ORDER BY AdiSoyadi ";

            VtBaglantisi vtBaglantisi = new();
            DataTable dt = vtBaglantisi.VeriGetir(sorgu);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Kisi kisi = DonusturDataRowdanKisiye(dr);
                    kisiler.Add(kisi);
                }
            }

            return kisiler;
        }

        private Kisi DonusturDataRowdanKisiye(DataRow dr)
        {
            Kisi kisi = new Kisi();

            kisi.KisiId = Convert.ToInt32(dr["KisiId"].ToString());
            kisi.GrupId = Convert.ToInt32(dr["GrupId"].ToString());
            kisi.AdiSoyadi = dr["AdiSoyadi"].ToString();
            kisi.Adres = (dr.IsNull("Adres")) ? "" : dr["Adres"].ToString();
            kisi.Isyeri = (dr.IsNull("Isyeri")) ? "" : dr["Isyeri"].ToString();
            kisi.Unvan = (dr.IsNull("Unvan")) ? "" : dr["Unvan"].ToString();
            kisi.Aciklama = (dr.IsNull("Aciklama")) ? "" : dr["Aciklama"].ToString();

            return kisi;
        }

    }
}
