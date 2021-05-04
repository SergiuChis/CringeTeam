namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sergiumigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubmissionDeadline = c.DateTime(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participations",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        SectionId = c.Int(nullable: false),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => new { t.UserId, t.SectionId })
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Participations", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Participations", new[] { "SectionId" });
            DropIndex("dbo.Participations", new[] { "UserId" });
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            DropTable("dbo.Users");
            DropTable("dbo.Participations");
            DropTable("dbo.Papers");
            DropTable("dbo.Sections");
            DropTable("dbo.Conferences");
        }
    }
}
