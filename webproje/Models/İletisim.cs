using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class İletisim
    {
        [Key]
        public  int iletisimId { get; set; }
        public string telefon { get; set; }

        public string firmaAdi { get; set; }

        public string eposta { get; set; }

        public string adres { get; set; }
        public int sehirId { get; set; }


    }
}