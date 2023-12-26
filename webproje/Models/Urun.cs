using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace webproje.Models
{
    public class Urun
    {

     
    


        public int urunId { get; set; }
        public string urunAdi { get; set; }
    
        public string urunAciklama { get; set; }
        public int fiyat { get; set; }
        public string renk { get; set; }
        public int kategoriId{ get; set; }

        public int markaId { get; set; }
        public int urunYorumId { get; set; }
        public string urunFoto { get; set; }
        public int urunStok { get; set; }

 
    }


}