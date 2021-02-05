namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19_01выбранноесостояниебезсвязиспланом : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", c => c.Int());
            CreateIndex("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId");
            AddForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", "dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.Справочник", new[] { "ВыбранноеСостояниеУстройства_УстройствоId" });
            DropColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId");
        }
    }
}
