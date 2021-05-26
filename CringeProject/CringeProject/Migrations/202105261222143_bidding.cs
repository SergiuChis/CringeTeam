namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bidding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PaperId = c.Int(nullable: false),
                        Interest = c.String(),
                    })
                .PrimaryKey(t => new { t.UserName, t.PaperId })
                .ForeignKey("dbo.Papers", t => t.PaperId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserName, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.PaperId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "UserName", "dbo.Users");
            DropForeignKey("dbo.Bids", "PaperId", "dbo.Papers");
            DropIndex("dbo.Bids", new[] { "PaperId" });
            DropIndex("dbo.Bids", new[] { "UserName" });
            DropTable("dbo.Bids");
        }
    }
}
