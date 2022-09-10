using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.Models;

namespace TelefonDefteri.DataAccess
{
    public class KisiYoneticisi 
    {
        public string Kaydet(Kisi kisi)
        {
            string sonuc = "";

            return sonuc;
        }

        public string Guncelle(Kisi kisi)
        {
            string sonuc = "";

            return sonuc;
        }

        public string Sil(Kisi kisi)
        {
            string sonuc = "";

            return sonuc;
        }

        public Kisi KisiGetir(int kisiId)
        {
            Kisi kisi = new();

            return kisi;
        }

        public List<Kisi> KisiListesiGetir(string aranan)
        {
            List<Kisi> kisiler = new();

            return kisiler;
        }

        
    }
}
