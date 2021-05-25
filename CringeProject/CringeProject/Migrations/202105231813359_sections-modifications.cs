namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sectionsmodifications : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            RenameColumn(table: "dbo.Sections", name: "ConferenceId", newName: "Conference_Id");
            AlterColumn("dbo.Sections", "Conference_Id", c => c.Int());
            CreateIndex("dbo.Sections", "Conference_Id");
            AddForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "Conference_Id", "dbo.Conferences");
            DropIndex("dbo.Sections", new[] { "Conference_Id" });
            AlterColumn("dbo.Sections", "Conference_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Sections", name: "Conference_Id", newName: "ConferenceId");
            CreateIndex("dbo.Sections", "ConferenceId");
            AddForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences", "Id", cascadeDelete: true);
        }
    }
}
