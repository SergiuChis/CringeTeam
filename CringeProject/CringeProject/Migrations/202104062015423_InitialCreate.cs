namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.String(),
                        AvailablePlaces = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserSection",
                c => new
                    {
                        UserRefId = c.Int(nullable: false),
                        SectionRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserRefId, t.SectionRefId })
                .ForeignKey("dbo.Users", t => t.UserRefId, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionRefId, cascadeDelete: true)
                .Index(t => t.UserRefId)
                .Index(t => t.SectionRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSection", "SectionRefId", "dbo.Sections");
            DropForeignKey("dbo.UserSection", "UserRefId", "dbo.Users");
            DropIndex("dbo.UserSection", new[] { "SectionRefId" });
            DropIndex("dbo.UserSection", new[] { "UserRefId" });
            DropTable("dbo.UserSection");
            DropTable("dbo.Users");
            DropTable("dbo.Sections");
        }
    }
}
