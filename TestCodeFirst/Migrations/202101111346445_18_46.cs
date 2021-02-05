namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18_46 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Устройство", "УстройствоId", "dbo.ВыбранноеСостояниеУстройства");
            DropIndex("dbo.Устройство", new[] { "УстройствоId" });
            DropPrimaryKey("dbo.ВыбранноеСостояниеУстройства");
            AddColumn("dbo.ВыбранноеСостояниеУстройства", "УстройствоId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
            CreateIndex("dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
            //DropColumn("dbo.ВыбранноеСостояниеУстройства", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ВыбранноеСостояниеУстройства", "Id", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.ВыбранноеСостояниеУстройства", new[] { "УстройствоId" });
            DropPrimaryKey("dbo.ВыбранноеСостояниеУстройства");
            DropColumn("dbo.ВыбранноеСостояниеУстройства", "УстройствоId");
            AddPrimaryKey("dbo.ВыбранноеСостояниеУстройства", "Id");
            CreateIndex("dbo.Устройство", "УстройствоId");
            AddForeignKey("dbo.Устройство", "УстройствоId", "dbo.ВыбранноеСостояниеУстройства", "Id");
        }
    }
}
