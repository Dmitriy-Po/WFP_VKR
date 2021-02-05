namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18_03 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.Справочник", new[] { "ВыбранноеСостояниеУстройства_Id" });
            DropColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", c => c.Int());
            CreateIndex("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id");
            AddForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_Id", "dbo.ВыбранноеСостояниеУстройства", "Id");
        }
    }
}
