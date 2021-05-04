namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoringDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Papers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Abstract = c.String(),
                        Body = c.String(),
                        Section_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Section_Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Section_Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.String(),
                        AvailablePlaces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Type = c.String(),
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
            DropForeignKey("dbo.Papers", "Id", "dbo.Users");
            DropForeignKey("dbo.Papers", "Section_Id", "dbo.Sections");
            DropIndex("dbo.UserSection", new[] { "SectionRefId" });
            DropIndex("dbo.UserSection", new[] { "UserRefId" });
            DropIndex("dbo.Papers", new[] { "Section_Id" });
            DropIndex("dbo.Papers", new[] { "Id" });
            DropTable("dbo.UserSection");
            DropTable("dbo.Users");
            DropTable("dbo.Sections");
            DropTable("dbo.Papers");
        }
    }
}
