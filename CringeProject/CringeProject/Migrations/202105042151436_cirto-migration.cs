namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cirtomigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Papers", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Papers", "SectionId", c => c.Int(nullable: false));
            AddColumn("dbo.Papers", "Abstract", c => c.String());
            AddColumn("dbo.Papers", "Body", c => c.String());
            CreateIndex("dbo.Papers", "UserId");
            CreateIndex("dbo.Papers", "SectionId");
            AddForeignKey("dbo.Papers", "SectionId", "dbo.Sections", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Papers", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Papers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Papers", "SectionId", "dbo.Sections");
            DropIndex("dbo.Papers", new[] { "SectionId" });
            DropIndex("dbo.Papers", new[] { "UserId" });
            DropColumn("dbo.Papers", "Body");
            DropColumn("dbo.Papers", "Abstract");
            DropColumn("dbo.Papers", "SectionId");
            DropColumn("dbo.Papers", "UserId");
        }
    }
}
