namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SwithFKs : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ВыбранноеСостояниеУстройства", new[] { "Id" });
            CreateIndex("dbo.Справочник", "Id");
            CreateIndex("dbo.Устройство", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Устройство", new[] { "Id" });
            DropIndex("dbo.Справочник", new[] { "Id" });
            CreateIndex("dbo.ВыбранноеСостояниеУстройства", "Id");
        }
    }
}
