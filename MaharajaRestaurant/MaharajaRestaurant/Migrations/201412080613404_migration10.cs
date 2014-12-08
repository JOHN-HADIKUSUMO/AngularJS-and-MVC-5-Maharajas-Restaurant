namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        WordAfterPrice = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.MenuID);
            
            CreateTable(
                "dbo.PhotoMenus",
                c => new
                    {
                        PhotoID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        Filename = c.String(),
                        GUIDFilename = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PhotoID)
                .ForeignKey("dbo.Menus", t => t.MenuID, cascadeDelete: true)
                .Index(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhotoMenus", "MenuID", "dbo.Menus");
            DropIndex("dbo.PhotoMenus", new[] { "MenuID" });
            DropTable("dbo.PhotoMenus");
            DropTable("dbo.Menus");
        }
    }
}
