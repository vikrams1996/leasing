namespace RentShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RightFormChangesToDetailsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Details", "Area", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "monthlyRevenue", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "payThrough", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Details", "payThrough");
            DropColumn("dbo.Details", "monthlyRevenue");
            DropColumn("dbo.Details", "Area");
        }
    }
}
