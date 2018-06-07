namespace RentShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUnitsRequiredTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UnitsRequireds (Id, Name, Amount) VALUES (1, 'One' , '40000' )");
            Sql("INSERT INTO UnitsRequireds (Id, Name, Amount) VALUES (2, 'Two' , '80000' )");
            Sql("INSERT INTO UnitsRequireds (Id, Name, Amount) VALUES (3, 'Three' , '120000' )");
            Sql("INSERT INTO UnitsRequireds (Id, Name, Amount) VALUES (4, 'Four' , '160000' )");
            Sql("INSERT INTO UnitsRequireds (Id, Name, Amount) VALUES (5, 'Five' , '200000' )");

        }

        public override void Down()
        {
            Sql("DELETE FROM UnitsRequireds WHERE in Id (1, 2, 3, 4, 5)");
        }
    }
}
