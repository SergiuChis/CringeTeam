namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Reviews", name: "User_UserName", newName: "UserName");
            RenameIndex(table: "dbo.Reviews", name: "IX_User_UserName", newName: "IX_UserName");
            DropColumn("dbo.Reviews", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "UserId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Reviews", name: "IX_UserName", newName: "IX_User_UserName");
            RenameColumn(table: "dbo.Reviews", name: "UserName", newName: "User_UserName");
        }
    }
}
