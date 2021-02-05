namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.РежимРаботыАгрегата", newName: "РежимРаботыСиловогоАгрегата");
            DropForeignKey("dbo.Устройство", "Id", "dbo.Справочник");
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство");
            DropIndex("dbo.Устройство", new[] { "Id" });
            RenameColumn(table: "dbo.СиловойАгрегатВУстройстве", name: "Агрегат_Id", newName: "ТехнологическоеУстройство_Id");
            RenameIndex(table: "dbo.СиловойАгрегатВУстройстве", name: "IX_Агрегат_Id", newName: "IX_ТехнологическоеУстройство_Id");
            DropPrimaryKey("dbo.Устройство");
            CreateTable(
                "dbo.ВыбранноеСостояниеУстройства",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        НаименованиеСостояния = c.String(maxLength: 50),
                        ТипЭнергии = c.Int(nullable: false),
                        РежимРаботы = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Справочник", t => t.Id)
                .ForeignKey("dbo.Устройство", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.СиловойАгрегатВУстройстве", "ТипЭнергии", c => c.Int(nullable: false));
            AddColumn("dbo.Устройство", "ДатаВыпуска", c => c.DateTime(nullable: false));
            AddColumn("dbo.РежимРаботыСиловогоАгрегата", "РежимРаботы", c => c.Int(nullable: false));
            AlterColumn("dbo.Устройство", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Устройство", "Id");
            AddForeignKey("dbo.СиловойАгрегатВУстройстве", "ТехнологическоеУстройство_Id", "dbo.Устройство", "Id");
            DropColumn("dbo.Устройство", "Потребление");
            DropColumn("dbo.Устройство", "Производительность");
            DropColumn("dbo.РежимРаботыСиловогоАгрегата", "Наименование");
        }
        
        public override void Down()
        {
            AddColumn("dbo.РежимРаботыСиловогоАгрегата", "Наименование", c => c.String());
            AddColumn("dbo.Устройство", "Производительность", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Устройство", "Потребление", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "ТехнологическоеУстройство_Id", "dbo.Устройство");
            DropForeignKey("dbo.ВыбранноеСостояниеУстройства", "Id", "dbo.Устройство");
            DropForeignKey("dbo.ВыбранноеСостояниеУстройства", "Id", "dbo.Справочник");
            DropIndex("dbo.ВыбранноеСостояниеУстройства", new[] { "Id" });
            DropPrimaryKey("dbo.Устройство");
            AlterColumn("dbo.Устройство", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.РежимРаботыСиловогоАгрегата", "РежимРаботы");
            DropColumn("dbo.Устройство", "ДатаВыпуска");
            DropColumn("dbo.СиловойАгрегатВУстройстве", "ТипЭнергии");
            DropTable("dbo.ВыбранноеСостояниеУстройства");
            AddPrimaryKey("dbo.Устройство", "Id");
            RenameIndex(table: "dbo.СиловойАгрегатВУстройстве", name: "IX_ТехнологическоеУстройство_Id", newName: "IX_Агрегат_Id");
            RenameColumn(table: "dbo.СиловойАгрегатВУстройстве", name: "ТехнологическоеУстройство_Id", newName: "Агрегат_Id");
            CreateIndex("dbo.Устройство", "Id");
            AddForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство", "Id");
            AddForeignKey("dbo.Устройство", "Id", "dbo.Справочник", "Id");
            RenameTable(name: "dbo.РежимРаботыСиловогоАгрегата", newName: "РежимРаботыАгрегата");
        }
    }
}
