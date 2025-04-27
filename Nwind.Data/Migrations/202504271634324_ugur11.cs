namespace Nwind.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ugur11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        RequiredDate = c.DateTime(nullable: false),
                        ShippedDate = c.DateTime(nullable: false),
                        ShipVia = c.Int(nullable: false),
                        Customer_CustomerID = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Customer_CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerID" });
            DropTable("dbo.Orders");
        }
    }
}
