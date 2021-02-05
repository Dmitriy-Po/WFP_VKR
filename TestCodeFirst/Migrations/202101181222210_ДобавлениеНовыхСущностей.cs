namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ДобавлениеНовыхСущностей : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.СправочникРесурсов",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        НаименованиеРесурса = c.String(maxLength: 50),
                        ТехнологическоеУстройство_УстройствоId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Устройство", t => t.ТехнологическоеУстройство_УстройствоId)
                .Index(t => t.ТехнологическоеУстройство_УстройствоId);
            
            AddColumn("dbo.РежимРаботыСиловогоАгрегата", "ТехнологическоеУстройство_УстройствоId", c => c.Int());
            CreateIndex("dbo.РежимРаботыСиловогоАгрегата", "ТехнологическоеУстройство_УстройствоId");
            AddForeignKey("dbo.РежимРаботыСиловогоАгрегата", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство", "УстройствоId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.СправочникРесурсов", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство");
            DropForeignKey("dbo.РежимРаботыСиловогоАгрегата", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство");
            DropIndex("dbo.СправочникРесурсов", new[] { "ТехнологическоеУстройство_УстройствоId" });
            DropIndex("dbo.РежимРаботыСиловогоАгрегата", new[] { "ТехнологическоеУстройство_УстройствоId" });
            DropColumn("dbo.РежимРаботыСиловогоАгрегата", "ТехнологическоеУстройство_УстройствоId");
            DropTable("dbo.СправочникРесурсов");
        }
    }
}
