using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webproje.Models
{
    public class UyeGirisModel
    {
        [Required(ErrorMessage = "Eposta alanı zorunludur.")]
        public string eposta { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string sifre { get; set; }
    }
}