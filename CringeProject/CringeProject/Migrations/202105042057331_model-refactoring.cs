namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelrefactoring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserSection", "UserRefId", "dbo.Users");
            DropForeignKey("dbo.UserSection", "SectionRefId", "dbo.Sections");
            DropForeignKey("dbo.Participations", "ConferenceId", "dbo.Conferences");
            DropForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences");
            DropIndex("dbo.Sections", new[] { "Conference_Id" });
            DropIndex("dbo.Participations", new[] { "ConferenceId" });
            DropIndex("dbo.UserSection", new[] { "UserRefId" });
            DropIndex("dbo.UserSection", new[] { "SectionRefId" });
            RenameColumn(table: "dbo.Participations", name: "ConferenceId", newName: "Conference_Id");
            RenameColumn(table: "dbo.Sections", name: "Conference_Id", newName: "ConferenceId");
            DropPrimaryKey("dbo.Participations");
            AddColumn("dbo.Participations", "SectionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Sections", "ConferenceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Participations", "Conference_Id", c => c.Int());
            AddPrimaryKey("dbo.Participations", new[] { "UserId", "SectionId" });
            CreateIndex("dbo.Participations", "SectionId");
            CreateIndex("dbo.Participations", "Conference_Id");
            CreateIndex("dbo.Sections", "ConferenceId");
            AddForeignKey("dbo.Participations", "SectionId", "dbo.Sections", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Participations", "Conference_Id", "dbo.Conferences", "Id");
            AddForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences", "Id", cascadeDelete: true);
            DropTable("dbo.UserSection");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserSection",
                c => new
                    {
                        UserRefId = c.Int(nullable: false),
                        SectionRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserRefId, t.SectionRefId });
            
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropForeignKey("dbo.Participations", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.Participations", "SectionId", "dbo.Sections");
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            DropIndex("dbo.Participations", new[] { "Conference_Id" });
            DropIndex("dbo.Participations", new[] { "SectionId" });
            DropPrimaryKey("dbo.Participations");
            AlterColumn("dbo.Participations", "Conference_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Sections", "ConferenceId", c => c.Int());
            DropColumn("dbo.Participations", "SectionId");
            AddPrimaryKey("dbo.Participations", new[] { "UserId", "ConferenceId" });
            RenameColumn(table: "dbo.Sections", name: "ConferenceId", newName: "Conference_Id");
            RenameColumn(table: "dbo.Participations", name: "Conference_Id", newName: "ConferenceId");
            CreateIndex("dbo.UserSection", "SectionRefId");
            CreateIndex("dbo.UserSection", "UserRefId");
            CreateIndex("dbo.Participations", "ConferenceId");
            CreateIndex("dbo.Sections", "Conference_Id");
            AddForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences", "Id");
            AddForeignKey("dbo.Participations", "ConferenceId", "dbo.Conferences", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserSection", "SectionRefId", "dbo.Sections", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserSection", "UserRefId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
