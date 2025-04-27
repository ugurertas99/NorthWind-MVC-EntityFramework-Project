namespace Nwind.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ugur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 5),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
