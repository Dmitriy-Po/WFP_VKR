namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _16_02 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Справочник", "Id", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.Справочник", new[] { "Id" });
            AddColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", c => c.Int());
            CreateIndex("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id");
            AddForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", "dbo.ВыбранноеСостояниеУстройства", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.Справочник", new[] { "ВыбранноеСостояниеУстройства_Id" });
            DropColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id");
            CreateIndex("dbo.Справочник", "Id");
            AddForeignKey("dbo.Справочник", "Id", "dbo.ВыбранноеСостояниеУстройства", "Id");
        }
    }
}
