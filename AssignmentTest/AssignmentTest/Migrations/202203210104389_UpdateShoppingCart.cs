namespace AssignmentTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShoppingCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Quantity");
        }
    }
}
