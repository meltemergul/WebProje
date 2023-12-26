using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class Hakkimizda
    {
        [Key]
        public int hakkımızdaId { get; set; }
        public string Aciklama { get; set; }

        
    }
}