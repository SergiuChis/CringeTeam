namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usermodelchanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Papers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Abstract = c.String(),
                        Body = c.String(),
                        Section_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Section_Id)
                .Index(t => t.Section_Id);
            
            AlterColumn("dbo.Sections", "AvailablePlaces", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Papers", "Section_Id", "dbo.Sections");
            DropIndex("dbo.Papers", new[] { "Section_Id" });
            AlterColumn("dbo.Sections", "AvailablePlaces", c => c.String());
            DropTable("dbo.Papers");
        }
    }
}
