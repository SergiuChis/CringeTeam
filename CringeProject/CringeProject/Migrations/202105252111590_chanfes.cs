namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chanfes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Papers", name: "User_UserName", newName: "UserName");
            RenameIndex(table: "dbo.Papers", name: "IX_User_UserName", newName: "IX_UserName");
            DropColumn("dbo.Papers", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Papers", "UserId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Papers", name: "IX_UserName", newName: "IX_User_UserName");
            RenameColumn(table: "dbo.Papers", name: "UserName", newName: "User_UserName");
        }
    }
}
