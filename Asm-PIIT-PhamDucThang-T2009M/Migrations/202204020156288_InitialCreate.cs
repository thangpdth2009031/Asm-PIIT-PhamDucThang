namespace Asm_PIIT_PhamDucThang_T2009M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BaseAsset = c.String(nullable: false),
                        QuoteAsset = c.String(nullable: false),
                        LastPrice = c.Double(nullable: false),
                        Volumn24h = c.Double(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Market_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.Market_Id)
                .Index(t => t.Market_Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "Market_Id", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "Market_Id" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
