namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conferencesdroppedparticipationId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Participations", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.Papers", "Section_Id", "dbo.Sections");
            DropIndex("dbo.Participations", new[] { "Conference_Id" });
            DropIndex("dbo.Papers", new[] { "Section_Id" });
            RenameColumn(table: "dbo.Papers", name: "Section_Id", newName: "SectionId");
            AlterColumn("dbo.Papers", "SectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Papers", "SectionId");
            AddForeignKey("dbo.Papers", "SectionId", "dbo.Sections", "Id", cascadeDelete: true);
            DropColumn("dbo.Participations", "Conference_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Participations", "Conference_Id", c => c.Int());
            DropForeignKey("dbo.Papers", "SectionId", "dbo.Sections");
            DropIndex("dbo.Papers", new[] { "SectionId" });
            AlterColumn("dbo.Papers", "SectionId", c => c.Int());
            RenameColumn(table: "dbo.Papers", name: "SectionId", newName: "Section_Id");
            CreateIndex("dbo.Papers", "Section_Id");
            CreateIndex("dbo.Participations", "Conference_Id");
            AddForeignKey("dbo.Papers", "Section_Id", "dbo.Sections", "Id");
            AddForeignKey("dbo.Participations", "Conference_Id", "dbo.Conferences", "Id");
        }
    }
}
