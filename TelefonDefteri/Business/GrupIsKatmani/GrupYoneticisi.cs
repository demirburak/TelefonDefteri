using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonDefteri.DataAccess;
using TelefonDefteri.Models;

namespace TelefonDefteri.Business.GrupIsKatmani
{
    public class GrupYoneticisi
    {
        public List<Grup> GrupListesiGetir()
        {
            List<Grup> liste = new List<Grup>();

            GrupVeriErisimi grupVeriErisimi = new GrupVeriErisimi();
            liste = grupVeriErisimi.GrupListesiGetir("");

            return liste;
        }
    }
}
