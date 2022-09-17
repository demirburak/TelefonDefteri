using System;
using System.Collections.Generic;
using System.Linq;
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
                " (KisiId,AdiSoyadi,ProfilResmi,Adres,Isyeri,Unvan,GrupId,Aciklama)" +
                " VALUES " +
               $" ({kisi.KisiId},'{kisi.AdiSoyadi}',null,'{kisi.Adres}','{kisi.Isyeri}','{kisi.Unvan}'," +
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

            return sonuc;
        }

        public Kisi KisiGetir(int kisiId)
        {
            Kisi kisi = new();

            string sorgu = $" SELECT * FROM Kisiler WHERE KisiId = {kisiId} ";

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
                $" OR Aciklama LIKE '%{aranan}%' ";

            return kisiler;
        }


    }
}
