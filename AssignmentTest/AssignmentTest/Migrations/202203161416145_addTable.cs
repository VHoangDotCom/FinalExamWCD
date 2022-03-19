namespace AssignmentTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CateID = c.Int(nullable: false),
                        ProductName = c.String(),
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
