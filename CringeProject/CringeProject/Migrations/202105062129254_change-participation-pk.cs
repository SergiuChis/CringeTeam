namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeparticipationpk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Participations", "User_UserName", "dbo.Users");
            DropIndex("dbo.Participations", new[] { "User_UserName" });
            RenameColumn(table: "dbo.Participations", name: "User_UserName", newName: "UserName");
            DropPrimaryKey("dbo.Participations");
            AlterColumn("dbo.Participations", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Participations", new[] { "UserName", "SectionId" });
            CreateIndex("dbo.Participations", "UserName");
            AddForeignKey("dbo.Participations", "UserName", "dbo.Users", "UserName", cascadeDelete: true);
            DropColumn("dbo.Participations", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Participations", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Participations", "UserName", "dbo.Users");
            DropIndex("dbo.Participations", new[] { "UserName" });
            DropPrimaryKey("dbo.Participations");
            AlterColumn("dbo.Participations", "UserName", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Participations", new[] { "UserId", "SectionId" });
            RenameColumn(table: "dbo.Participations", name: "UserName", newName: "User_UserName");
            CreateIndex("dbo.Participations", "User_UserName");
            AddForeignKey("dbo.Participations", "User_UserName", "dbo.Users", "UserName");
        }
    }
}
