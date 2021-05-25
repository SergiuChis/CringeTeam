namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sectionsmodifications2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences");
            DropIndex("dbo.Sections", new[] { "Conference_Id" });
            RenameColumn(table: "dbo.Sections", name: "Conference_Id", newName: "ConferenceId");
            AlterColumn("dbo.Sections", "ConferenceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sections", "ConferenceId");
            AddForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            AlterColumn("dbo.Sections", "ConferenceId", c => c.Int());
            RenameColumn(table: "dbo.Sections", name: "ConferenceId", newName: "Conference_Id");
            CreateIndex("dbo.Sections", "Conference_Id");
            AddForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences", "Id");
        }
    }
}
