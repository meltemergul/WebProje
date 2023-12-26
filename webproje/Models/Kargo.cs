using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class Kargo
    {
        public int kargoId { get; set; }
        public string kargoAdi { get; set; }
  
        public string Telefon { get; set; }

        public string Adres { get; set; }
        public int  sehirId { get; set; }


    }
}