namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Papers", "Id", "dbo.Users");
            DropColumn("dbo.Papers", "UserId");
            RenameColumn(table: "dbo.Papers", name: "Id", newName: "UserId");
            RenameIndex(table: "dbo.Papers", name: "IX_Id", newName: "IX_UserId");
            DropPrimaryKey("dbo.Papers");
            AlterColumn("dbo.Papers", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Papers", "Id");
            AddForeignKey("dbo.Papers", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Papers", "UserId", "dbo.Users");
            DropPrimaryKey("dbo.Papers");
            AlterColumn("dbo.Papers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Papers", "Id");
            RenameIndex(table: "dbo.Papers", name: "IX_UserId", newName: "IX_Id");
            RenameColumn(table: "dbo.Papers", name: "UserId", newName: "Id");
            AddColumn("dbo.Papers", "UserId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Papers", "Id", "dbo.Users", "Id");
        }
    }
}
