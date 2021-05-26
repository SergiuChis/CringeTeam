namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AbstractDeadline = c.DateTime(nullable: false),
                        PaperDeadline = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConferenceId = c.Int(nullable: false),
                        Room = c.String(),
                        AvailablePlaces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conferences", t => t.ConferenceId, cascadeDelete: true)
                .Index(t => t.ConferenceId);
            
            CreateTable(
                "dbo.Papers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SectionId = c.Int(nullable: false),
                        Abstract = c.String(),
                        Body = c.String(),
                        User_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserName)
                .Index(t => t.SectionId)
                .Index(t => t.User_UserName);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Participations",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        SectionId = c.Int(nullable: false),
                        UserType = c.String(),
                        IsSectionChair = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserName, t.SectionId })
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserName, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.SectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Papers", "User_UserName", "dbo.Users");
            DropForeignKey("dbo.Participations", "UserName", "dbo.Users");
            DropForeignKey("dbo.Participations", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Papers", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Participations", new[] { "SectionId" });
            DropIndex("dbo.Participations", new[] { "UserName" });
            DropIndex("dbo.Papers", new[] { "User_UserName" });
            DropIndex("dbo.Papers", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            DropTable("dbo.Participations");
            DropTable("dbo.Users");
            DropTable("dbo.Papers");
            DropTable("dbo.Sections");
            DropTable("dbo.Conferences");
        }
    }
}
