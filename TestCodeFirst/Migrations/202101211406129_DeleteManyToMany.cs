namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", "dbo.СиловойАгрегатВУстановке");
            DropForeignKey("dbo.УстановкаРежимРесурс", "РесурсId", "dbo.СправочникРесурсов");
            DropIndex("dbo.УстановкаРежимРесурс", new[] { "РесурсId" });
            DropIndex("dbo.УстановкаРежимРесурс", new[] { "СиловойАгрегатВУстановкеId" });
            //DropPrimaryKey("dbo.УстановкаРежимРесурс");
            AddColumn("dbo.УстановкаРежимРесурс", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеFK", c => c.Int(nullable: false));
            AddColumn("dbo.УстановкаРежимРесурс", "СправочникРесурсовFK", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.УстановкаРежимРесурс", "Id");
            //DropColumn("dbo.УстановкаРежимРесурс", "РесурсId");
            //DropColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", c => c.Int(nullable: false));
            //AddColumn("dbo.УстановкаРежимРесурс", "РесурсId", c => c.Int(nullable: false));
            //DropPrimaryKey("dbo.УстановкаРежимРесурс");
            DropColumn("dbo.УстановкаРежимРесурс", "СправочникРесурсовFK");
            DropColumn("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеFK");
            DropColumn("dbo.УстановкаРежимРесурс", "Id");
            //AddPrimaryKey("dbo.УстановкаРежимРесурс", new[] { "РесурсId", "СиловойАгрегатВУстановкеId" });
            //CreateIndex("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId");
            //CreateIndex("dbo.УстановкаРежимРесурс", "РесурсId");
            //AddForeignKey("dbo.УстановкаРежимРесурс", "РесурсId", "dbo.СправочникРесурсов", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.УстановкаРежимРесурс", "СиловойАгрегатВУстановкеId", "dbo.СиловойАгрегатВУстановке", "Id", cascadeDelete: true);
        }
    }
}
