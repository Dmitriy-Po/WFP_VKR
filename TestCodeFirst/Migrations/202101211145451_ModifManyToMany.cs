namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifManyToMany : DbMigration
    {
        public override void Up()
        {
           // DropForeignKey("dbo.УстановкаРежимРесурс", "РежимРаботыАгрегатаId", "dbo.РежимРаботыАгрегата");
            //DropForeignKey("dbo.СиловойАгрегатВУстановке", "СправочникРесурсов_Id", "dbo.СправочникРесурсов");
            //DropIndex("dbo.СиловойАгрегатВУстановке", new[] { "СправочникРесурсов_Id" });
            //DropIndex("dbo.УстановкаРежимРесурс", new[] { "РежимРаботыАгрегатаId" });
            //DropPrimaryKey("dbo.УстановкаРежимРесурс");
            //AddColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.УстановкаРежимРесурс", new[] { "РесурсId", "СиловойАгрегатВУстановкеId" });
            //CreateIndex("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId");
            //AddForeignKey("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", "dbo.СиловойАгрегатВУстановке", "Id", cascadeDelete: true);
            //DropColumn("dbo.СиловойАгрегатВУстановке", "СправочникРесурсов_Id");
            //DropColumn("dbo.УстановкаРежимРесурс", "РежимРаботыАгрегатаId");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.УстановкаРежимРесурс", "РежимРаботыАгрегатаId", c => c.Int(nullable: false));
            //AddColumn("dbo.СиловойАгрегатВУстановке", "СправочникРесурсов_Id", c => c.Int());
            //DropForeignKey("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", "dbo.СиловойАгрегатВУстановке");
            //DropIndex("dbo.УстановкаРежимРесурс", new[] { "СиловойАгрегатВУстановкеId" });
            //DropPrimaryKey("dbo.УстановкаРежимРесурс");
            //DropColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId");
            //AddPrimaryKey("dbo.УстановкаРежимРесурс", new[] { "РесурсId", "РежимРаботыАгрегатаId" });
            //CreateIndex("dbo.УстановкаРежимРесурс", "РежимРаботыАгрегатаId");
            //CreateIndex("dbo.СиловойАгрегатВУстановке", "СправочникРесурсов_Id");
            //AddForeignKey("dbo.СиловойАгрегатВУстановке", "СправочникРесурсов_Id", "dbo.СправочникРесурсов", "Id");
            //AddForeignKey("dbo.УстановкаРежимРесурс", "РежимРаботыАгрегатаId", "dbo.РежимРаботыАгрегата", "Id", cascadeDelete: true);
        }
    }
}
