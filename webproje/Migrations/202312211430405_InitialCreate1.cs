namespace webproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        markaId = c.Int(nullable: false, identity: true),
                        markaAdi = c.String(),
                    })
                .PrimaryKey(t => t.markaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Markas");
        }
    }
}
