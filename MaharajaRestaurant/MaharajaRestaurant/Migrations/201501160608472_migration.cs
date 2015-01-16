namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        UserID = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Menus", t => t.MenuID, cascadeDelete: true)
                .Index(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "MenuID", "dbo.Menus");
            DropIndex("dbo.Comments", new[] { "MenuID" });
            DropTable("dbo.Comments");
        }
    }
}
