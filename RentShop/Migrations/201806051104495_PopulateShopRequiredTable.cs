namespace RentShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateShopRequiredTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (1, 'Food') ");
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (2, 'Sports') ");
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (3, 'Electronics') ");
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (4, 'Games') ");
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (5, 'Clothing') ");
            Sql("INSERT INTO ShopRequireds ( Id , Name) VALUES (6, 'Club') ");
        }

        public override void Down()
        {
            Sql("DELETE FROM ShopRequireds WHERE in Id (1, 2, 3, 4, 5, 6)");
        }
    }
}
