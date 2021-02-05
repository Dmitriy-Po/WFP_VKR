namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ВыбранноеСостояниеУстройства", "УстройствоId", "dbo.Устройство");
            DropForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.ВыбранноеСостояниеУстройства", new[] { "УстройствоId" });
            DropIndex("dbo.Справочник", new[] { "ВыбранноеСостояниеУстройства_УстройствоId" });
            AddColumn("dbo.Справочник", "ТипЭнергии", c => c.Int());
            AddColumn("dbo.Справочник", "РежимРаботы", c => c.Int());
            DropTable("dbo.ВыбранноеСостояниеУстройства");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ВыбранноеСостояниеУстройства",
                c => new
                    {
                        УстройствоId = c.Int(nullable: false),
                        НаименованиеСостояния = c.String(maxLength: 50),
                        ТипЭнергии = c.Int(nullable: false),
                        РежимРаботы = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.УстройствоId);
            
            AddColumn("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", c => c.Int());
            DropColumn("dbo.Справочник", "РежимРаботы");
            DropColumn("dbo.Справочник", "ТипЭнергии");
            CreateIndex("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId");
            CreateIndex("dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
            AddForeignKey("dbo.Справочник", "ВыбранноеСостояниеУстройства_УстройствоId", "dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
            AddForeignKey("dbo.ВыбранноеСостояниеУстройства", "УстройствоId", "dbo.Устройство", "УстройствоId");
        }
    }
}
