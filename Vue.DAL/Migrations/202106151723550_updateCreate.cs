namespace Vue.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "User_Id", "dbo.Users");
            DropIndex("dbo.Products", new[] { "User_Id" });
            AddColumn("dbo.Products", "User_Id1", c => c.Int());
            AlterColumn("dbo.Products", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "User_Id1");
            AddForeignKey("dbo.Products", "User_Id1", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "User_Id1", "dbo.Users");
            DropIndex("dbo.Products", new[] { "User_Id1" });
            AlterColumn("dbo.Products", "User_Id", c => c.Int());
            DropColumn("dbo.Products", "User_Id1");
            CreateIndex("dbo.Products", "User_Id");
            AddForeignKey("dbo.Products", "User_Id", "dbo.Users", "Id");
        }
    }
}
