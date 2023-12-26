namespace webproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        kategoriId = c.Int(nullable: false, identity: true),
                        kategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.kategoriId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kategoris");
        }
    }
}
