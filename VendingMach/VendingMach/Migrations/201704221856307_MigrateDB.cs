namespace VendingMach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Beverages", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Beverages", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
