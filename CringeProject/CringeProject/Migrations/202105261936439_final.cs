namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conferences", "BidProposalDeadline", c => c.DateTime(nullable: false));
            AddColumn("dbo.Conferences", "ReviewDeadline", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Conferences", "ReviewDeadline");
            DropColumn("dbo.Conferences", "BidProposalDeadline");
        }
    }
}
