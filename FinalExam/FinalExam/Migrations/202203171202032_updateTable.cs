namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "SuppilerID", c => c.Int(nullable: false));
            DropColumn("dbo.Product", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Product", "SuppilerID", c => c.String());
        }
    }
}
