using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class sehir
    {
        public int SehirId { get; set; }

        [Display(Name = "Şehir Adı")]
        public string SehirAdi { get; set; }
    }
}