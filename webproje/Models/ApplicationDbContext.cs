using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace webproje.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("data source=DESKTOP-QOAO744\\SQLEXPRESS;initial catalog=canta;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }
        public DbSet<sehir> Sehirler { get; set; }
        public DbSet<Hakkimizda> hakkimizda { get; set; }
        public DbSet<İletisim> iletisim { get; set; }

        public DbSet<Kategori> kategoriler { get; set; }
        public DbSet<Marka> markalar { get;  set; }

        public DbSet<Siparis> siparisler { get; set; }
        public DbSet<Urun> urunler { get; set; }

        public DbSet<Kargo> kargolar { get; set; }
        public DbSet<Uye> uyeler { get; set; }
    }
}