namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModePowerTODevice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.РежимРаботыУстановки",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        РежимРаботы = c.Int(nullable: false),
                        Производительность = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ТехнологическаяУстановка_УстройствоId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Установка", t => t.ТехнологическаяУстановка_УстройствоId)
                .Index(t => t.ТехнологическаяУстановка_УстройствоId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.РежимРаботыУстановки", "ТехнологическаяУстановка_УстройствоId", "dbo.Установка");
            DropIndex("dbo.РежимРаботыУстановки", new[] { "ТехнологическаяУстановка_УстройствоId" });
            DropTable("dbo.РежимРаботыУстановки");
        }
    }
}
