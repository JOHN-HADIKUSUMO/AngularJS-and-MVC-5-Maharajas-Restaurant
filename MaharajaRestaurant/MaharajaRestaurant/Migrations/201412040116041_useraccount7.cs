namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useraccount7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Mobile", c => c.String());
            AddColumn("dbo.AspNetUsers", "Street1", c => c.String());
            AddColumn("dbo.AspNetUsers", "Street2", c => c.String());
            AddColumn("dbo.AspNetUsers", "Suburb", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "PostCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PostCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "Suburb");
            DropColumn("dbo.AspNetUsers", "Street2");
            DropColumn("dbo.AspNetUsers", "Street1");
            DropColumn("dbo.AspNetUsers", "Mobile");
        }
    }
}
