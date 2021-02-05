namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyThirdTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.РежимРаботыСиловогоАгрегата", newName: "РежимРаботыУстановки");
            DropForeignKey("dbo.СправочникРесурсовТехнологическоеУстройство", "СправочникРесурсов_Id", "dbo.СправочникРесурсов");
            DropForeignKey("dbo.СправочникРесурсовТехнологическоеУстройство", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство");
            DropIndex("dbo.СправочникРесурсовТехнологическоеУстройство", new[] { "СправочникРесурсов_Id" });
            DropIndex("dbo.СправочникРесурсовТехнологическоеУстройство", new[] { "ТехнологическоеУстройство_УстройствоId" });
            CreateTable(
                "dbo.УстройствоРежимРесурс",
                c => new
                    {
                        РесурсId = c.Int(nullable: false),
                        УстановкаId = c.Int(nullable: false),
                        РежимРаботыУстановкиId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.РесурсId, t.УстановкаId, t.РежимРаботыУстановкиId })
                .ForeignKey("dbo.РежимРаботыУстановки", t => t.РежимРаботыУстановкиId, cascadeDelete: true)
                .ForeignKey("dbo.СправочникРесурсов", t => t.РесурсId, cascadeDelete: true)
                .ForeignKey("dbo.Устройство", t => t.УстановкаId, cascadeDelete: true)
                .Index(t => t.РесурсId)
                .Index(t => t.УстановкаId)
                .Index(t => t.РежимРаботыУстановкиId);
            
            DropTable("dbo.СправочникРесурсовТехнологическоеУстройство");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.СправочникРесурсовТехнологическоеУстройство",
                c => new
                    {
                        СправочникРесурсов_Id = c.Int(nullable: false),
                        ТехнологическоеУстройство_УстройствоId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.СправочникРесурсов_Id, t.ТехнологическоеУстройство_УстройствоId });
            
            DropForeignKey("dbo.УстройствоРежимРесурс", "УстановкаId", "dbo.Устройство");
            DropForeignKey("dbo.УстройствоРежимРесурс", "РесурсId", "dbo.СправочникРесурсов");
            DropForeignKey("dbo.УстройствоРежимРесурс", "РежимРаботыУстановкиId", "dbo.РежимРаботыУстановки");
            DropIndex("dbo.УстройствоРежимРесурс", new[] { "РежимРаботыУстановкиId" });
            DropIndex("dbo.УстройствоРежимРесурс", new[] { "УстановкаId" });
            DropIndex("dbo.УстройствоРежимРесурс", new[] { "РесурсId" });
            DropTable("dbo.УстройствоРежимРесурс");
            CreateIndex("dbo.СправочникРесурсовТехнологическоеУстройство", "ТехнологическоеУстройство_УстройствоId");
            CreateIndex("dbo.СправочникРесурсовТехнологическоеУстройство", "СправочникРесурсов_Id");
            AddForeignKey("dbo.СправочникРесурсовТехнологическоеУстройство", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство", "УстройствоId", cascadeDelete: true);
            AddForeignKey("dbo.СправочникРесурсовТехнологическоеУстройство", "СправочникРесурсов_Id", "dbo.СправочникРесурсов", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.РежимРаботыУстановки", newName: "РежимРаботыСиловогоАгрегата");
        }
    }
}
