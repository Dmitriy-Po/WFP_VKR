namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRelDevInMode : DbMigration
    {
        public override void Up()
        {
            ////DropForeignKey("dbo.РежимРаботыАгрегата", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство");
            //DropIndex("dbo.РежимРаботыАгрегата", new[] { "ТехнологическоеУстройство_УстройствоId" });
           // DropColumn("dbo.РежимРаботыАгрегата", "ТехнологическоеУстройство_УстройствоId");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.РежимРаботыАгрегата", "ТехнологическоеУстройство_УстройствоId", c => c.Int());
            //CreateIndex("dbo.РежимРаботыАгрегата", "ТехнологическоеУстройство_УстройствоId");
            //AddForeignKey("dbo.РежимРаботыАгрегата", "ТехнологическоеУстройство_УстройствоId", "dbo.Устройство", "УстройствоId");
        }
    }
}
