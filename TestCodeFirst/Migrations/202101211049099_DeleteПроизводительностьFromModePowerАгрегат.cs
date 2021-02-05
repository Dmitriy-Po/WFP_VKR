namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteПроизводительностьFromModePowerАгрегат : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.РежимРаботыАгрегата", "Производительность");
        }
        
        public override void Down()
        {
            AddColumn("dbo.РежимРаботыАгрегата", "Производительность", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
