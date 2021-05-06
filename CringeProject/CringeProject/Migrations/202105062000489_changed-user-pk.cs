namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeduserpk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Papers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Participations", "UserId", "dbo.Users");
            DropIndex("dbo.Papers", new[] { "UserId" });
            DropIndex("dbo.Participations", new[] { "UserId" });
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Papers", "User_UserName", c => c.String(maxLength: 128));
            AddColumn("dbo.Participations", "User_UserName", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "UserName");
            CreateIndex("dbo.Papers", "User_UserName");
            CreateIndex("dbo.Participations", "User_UserName");
            AddForeignKey("dbo.Papers", "User_UserName", "dbo.Users", "UserName");
            AddForeignKey("dbo.Participations", "User_UserName", "dbo.Users", "UserName");
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Participations", "User_UserName", "dbo.Users");
            DropForeignKey("dbo.Papers", "User_UserName", "dbo.Users");
            DropIndex("dbo.Participations", new[] { "User_UserName" });
            DropIndex("dbo.Papers", new[] { "User_UserName" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserName", c => c.String());
            DropColumn("dbo.Participations", "User_UserName");
            DropColumn("dbo.Papers", "User_UserName");
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Participations", "UserId");
            CreateIndex("dbo.Papers", "UserId");
            AddForeignKey("dbo.Participations", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Papers", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
