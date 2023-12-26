using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class Siparis
    {
        public int siparisId { get; set; }
        public int urunId { get; set; }

        public DateTime siparisTarihi { get; set; }

        public int uyeId { get; set; }
        public int adet { get; set; }
        public int kargoId { get; set; }

        public int siparisDurumId { get; set; }

  
    }
}