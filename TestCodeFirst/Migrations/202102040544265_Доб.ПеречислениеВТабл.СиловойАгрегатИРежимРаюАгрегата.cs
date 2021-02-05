namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ДобПеречислениеВТаблСиловойАгрегатИРежимРаюАгрегата : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.СиловойАгрегатВУстановке", "ТипЕдиницИзмерения", c => c.Int(nullable: false));
            AddColumn("dbo.РежимРаботыАгрегата", "ТипЕдиниц", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.РежимРаботыАгрегата", "ТипЕдиниц");
            DropColumn("dbo.СиловойАгрегатВУстановке", "ТипЕдиницИзмерения");
        }
    }
}
