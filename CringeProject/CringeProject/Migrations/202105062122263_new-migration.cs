namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conferences", "AbstractDeadline", c => c.DateTime(nullable: false));
            AddColumn("dbo.Conferences", "PaperDeadline", c => c.DateTime(nullable: false));
            AddColumn("dbo.Conferences", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Conferences", "EndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Conferences", "SubmissionDeadline");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conferences", "SubmissionDeadline", c => c.DateTime(nullable: false));
            DropColumn("dbo.Conferences", "EndDate");
            DropColumn("dbo.Conferences", "StartDate");
            DropColumn("dbo.Conferences", "PaperDeadline");
            DropColumn("dbo.Conferences", "AbstractDeadline");
        }
    }
}
