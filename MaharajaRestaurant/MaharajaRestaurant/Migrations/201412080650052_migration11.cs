namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhotoMenus", "MenuID", "dbo.Menus");
            DropIndex("dbo.PhotoMenus", new[] { "MenuID" });
            DropTable("dbo.Menus");
            DropTable("dbo.PhotoMenus");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.PhotoID);
            
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
            
            CreateIndex("dbo.PhotoMenus", "MenuID");
            AddForeignKey("dbo.PhotoMenus", "MenuID", "dbo.Menus", "MenuID", cascadeDelete: true);
        }
    }
}
