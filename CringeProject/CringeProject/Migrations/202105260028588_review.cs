namespace CringeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PaperId = c.Int(nullable: false),
                        Grade = c.String(),
                        User_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Papers", t => t.PaperId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserName)
                .Index(t => t.PaperId)
                .Index(t => t.User_UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "User_UserName", "dbo.Users");
            DropForeignKey("dbo.Reviews", "PaperId", "dbo.Papers");
            DropIndex("dbo.Reviews", new[] { "User_UserName" });
            DropIndex("dbo.Reviews", new[] { "PaperId" });
            DropTable("dbo.Reviews");
        }
    }
}
