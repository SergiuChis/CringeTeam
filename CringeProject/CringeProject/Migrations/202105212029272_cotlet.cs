namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cotlet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participations", "IsSectionChair", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participations", "IsSectionChair");
        }
    }
}
