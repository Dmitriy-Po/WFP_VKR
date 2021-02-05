namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Устройство",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Марка = c.String(),
                        Модель = c.String(),
                        Описание = c.String(),
                        Потребление = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Производительность = c.Decimal(nullable: false, precision: 18, scale: 2),
                        АгрегатID = c.Guid(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Справочник", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Справочник",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ДатаНачала = c.DateTime(nullable: false),
                        ДатаЗавершения = c.DateTime(nullable: false),
                        Описание = c.String(),
                        ПланНормативныйТехнологическийID = c.Guid(),
                        ЦелевойОбъёмПроизводства = c.Decimal(precision: 18, scale: 2),
                        КоличествоЧасовРаботы = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ФактическоеПотребление",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ВремяЗамераПотребления = c.DateTime(nullable: false),
                        ЗначениеПотребления = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ПланНормативныйТехнологический_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Справочник", t => t.ПланНормативныйТехнологический_Id)
                .Index(t => t.ПланНормативныйТехнологический_Id);
            
            CreateTable(
                "dbo.СиловойАгрегатВУстройстве",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Наименование = c.String(),
                        Агрегат_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Устройство", t => t.Агрегат_Id)
                .Index(t => t.Агрегат_Id);
            
            CreateTable(
                "dbo.РежимРаботыАгрегата",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Наименование = c.String(),
                        Потребление = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Производительность = c.Decimal(nullable: false, precision: 18, scale: 2),
                        СиловойАгрегатВУстройстве_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.СиловойАгрегатВУстройстве", t => t.СиловойАгрегатВУстройстве_Id)
                .Index(t => t.СиловойАгрегатВУстройстве_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.РежимРаботыАгрегата", "СиловойАгрегатВУстройстве_Id", "dbo.СиловойАгрегатВУстройстве");
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство");
            DropForeignKey("dbo.Устройство", "Id", "dbo.Справочник");
            DropForeignKey("dbo.ФактическоеПотребление", "ПланНормативныйТехнологический_Id", "dbo.Справочник");
            DropIndex("dbo.РежимРаботыАгрегата", new[] { "СиловойАгрегатВУстройстве_Id" });
            DropIndex("dbo.СиловойАгрегатВУстройстве", new[] { "Агрегат_Id" });
            DropIndex("dbo.ФактическоеПотребление", new[] { "ПланНормативныйТехнологический_Id" });
            DropIndex("dbo.Устройство", new[] { "Id" });
            DropTable("dbo.РежимРаботыАгрегата");
            DropTable("dbo.СиловойАгрегатВУстройстве");
            DropTable("dbo.ФактическоеПотребление");
            DropTable("dbo.Справочник");
            DropTable("dbo.Устройство");
        }
    }
}
