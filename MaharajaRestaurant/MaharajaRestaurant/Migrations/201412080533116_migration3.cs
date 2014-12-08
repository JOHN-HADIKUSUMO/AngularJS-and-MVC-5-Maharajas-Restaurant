namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhotoMenus", "MenuID", "dbo.Menus");
            DropIndex("dbo.PhotoMenus", new[] { "MenuID" });
            DropColumn("dbo.Menus", "CreatedDate");
            DropColumn("dbo.Menus", "IsDeleted");
            DropColumn("dbo.Menus", "DeletedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "DeletedDate", c => c.DateTime());
            AddColumn("dbo.Menus", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Menus", "CreatedDate", c => c.DateTime());
            CreateIndex("dbo.PhotoMenus", "MenuID");
            AddForeignKey("dbo.PhotoMenus", "MenuID", "dbo.Menus", "MenuID", cascadeDelete: true);
        }
    }
}
