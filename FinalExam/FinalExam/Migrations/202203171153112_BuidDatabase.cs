namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuidDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CateID = c.Int(nullable: false),
                        ProductName = c.String(),
                        SuppilerID = c.String(),
                        QuantityPerUnit = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        UnitsInStock = c.String(),
                        UnitsOnOrder = c.String(),
                        ReorderLevel = c.String(),
                        Discontinued = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CateID, cascadeDelete: true)
                .Index(t => t.CateID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CateID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "CateID" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
