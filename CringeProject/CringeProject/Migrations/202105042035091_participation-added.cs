namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class participationadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participations",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ConferenceId = c.Int(nullable: false),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => new { t.UserId, t.ConferenceId })
                .ForeignKey("dbo.Conferences", t => t.ConferenceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ConferenceId);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubmissionDeadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sections", "Conference_Id", c => c.Int());
            CreateIndex("dbo.Sections", "Conference_Id");
            AddForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences", "Id");
            DropColumn("dbo.Users", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Type", c => c.String());
            DropForeignKey("dbo.Participations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.Participations", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Participations", new[] { "ConferenceId" });
            DropIndex("dbo.Participations", new[] { "UserId" });
            DropIndex("dbo.Sections", new[] { "Conference_Id" });
            DropColumn("dbo.Sections", "Conference_Id");
            DropTable("dbo.Conferences");
            DropTable("dbo.Participations");
        }
    }
}
