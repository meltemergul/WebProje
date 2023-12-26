namespace webproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hakkimizdas",
                c => new
                    {
                        hakkımızdaId = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.hakkımızdaId);
            


            CreateTable(
                "dbo.İletisim",
                c => new
                    {
                        iletisimId = c.Int(nullable: false, identity: true),
                        telefon = c.String(),
                        firmaAdi = c.String(),
                        eposta = c.String(),
                        adres = c.String(),
                        sehirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.iletisimId);
            
            CreateTable(
                "dbo.Kargoes",
                c => new
                    {
                        kargoId = c.Int(nullable: false, identity: true),
                        kargoAdi = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        SehirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.kargoId)
                .ForeignKey("dbo.Sehirs", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId);
            
            CreateTable(
                "dbo.Sehirs",
                c => new
                    {
                        sehirId = c.Int(nullable: false, identity: true),
                        sehirAdi = c.String(),
                    })
                .PrimaryKey(t => t.sehirId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        kategoriId = c.Int(nullable: false, identity: true),
                        kategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.kategoriId);
            
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        markaId = c.Int(nullable: false, identity: true),
                        markaAdi = c.String(),
                    })
                .PrimaryKey(t => t.markaId);
            
            CreateTable(
                "dbo.sehirs",
                c => new
                    {
                        SehirId = c.Int(nullable: false, identity: true),
                        SehirAdi = c.String(),
                    })
                .PrimaryKey(t => t.SehirId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        siparisId = c.Int(nullable: false, identity: true),
                        urunId = c.Int(nullable: false),
                        siparisTarihi = c.DateTime(nullable: false),
                        uyeId = c.Int(nullable: false),
                        adet = c.Int(nullable: false),
                        kargoId = c.Int(nullable: false),
                        siparisDurumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.siparisId);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        urunId = c.Int(nullable: false, identity: true),
                        urunAdi = c.String(),
                        urunAciklama = c.String(),
                        fiyat = c.Int(nullable: false),
                        renk = c.String(),
                        kategoriId = c.Int(nullable: false),
                        markaId = c.Int(nullable: false),
                        urunYorumId = c.Int(nullable: false),
                        urunFoto = c.String(),
                        urunStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urunId);
            
            CreateTable(
                "dbo.Uyes",
                c => new
                    {
                        uyeId = c.Int(nullable: false, identity: true),
                        uyeAdi = c.String(),
                        uyeSoyadi = c.String(),
                        eposta = c.String(),
                        sifre = c.String(),
                        telefon = c.String(),
                        uyeAdresId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.uyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kargoes", "SehirId", "dbo.Sehirs");
            DropIndex("dbo.Kargoes", new[] { "SehirId" });
            DropTable("dbo.Uyes");
            DropTable("dbo.Uruns");
            DropTable("dbo.Siparis");
            DropTable("dbo.sehirs");
            DropTable("dbo.Markas");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Sehirs");
            DropTable("dbo.Kargoes");
            DropTable("dbo.İletisim");
            DropTable("dbo.Hakkimizdas");
        }
    }
}
