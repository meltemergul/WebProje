using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class Uye
    {

        public int uyeId { get; set; }
        public string uyeAdi { get; set; }
        public string uyeSoyadi { get; set; }

        public string eposta { get; set; }
        public string sifre { get; set; }
        public string telefon { get; set; }
        public int uyeAdresId { get; set; }

    }

  
}
