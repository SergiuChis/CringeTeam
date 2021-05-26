namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewAssignments",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PaperId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserName, t.PaperId })
                .ForeignKey("dbo.Papers", t => t.PaperId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserName, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.PaperId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewAssignments", "UserName", "dbo.Users");
            DropForeignKey("dbo.ReviewAssignments", "PaperId", "dbo.Papers");
            DropIndex("dbo.ReviewAssignments", new[] { "PaperId" });
            DropIndex("dbo.ReviewAssignments", new[] { "UserName" });
            DropTable("dbo.ReviewAssignments");
        }
    }
}
