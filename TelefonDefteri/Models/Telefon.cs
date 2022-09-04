using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri.Models
{
    public class Telefon
    {
        public int TelefonId { get; set; }

        public string TelefonNumarasi { get; set; }

        public string Tur { get; set; }

        public int KisiId { get; set; }
    }
}
