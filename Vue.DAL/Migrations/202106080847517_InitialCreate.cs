namespace Vue.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        usernaname = c.String(),
                        password = c.String(),
                        Admin_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Admins", t => t.Admin_id)
                .Index(t => t.Admin_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Admin_id", "dbo.Admins");
            DropIndex("dbo.Users", new[] { "Admin_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
