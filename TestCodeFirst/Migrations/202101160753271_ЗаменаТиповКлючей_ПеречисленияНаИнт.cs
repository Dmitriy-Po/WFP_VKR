namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ЗаменаТиповКлючей_ПеречисленияНаИнт : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Справочник", "ТипЭнергииId", c => c.Int());
            AddColumn("dbo.Справочник", "РежимРаботыId", c => c.Int());
            DropColumn("dbo.Справочник", "ТипЭнергии");
            DropColumn("dbo.Справочник", "РежимРаботы");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Справочник", "РежимРаботы", c => c.Int());
            AddColumn("dbo.Справочник", "ТипЭнергии", c => c.Int());
            DropColumn("dbo.Справочник", "РежимРаботыId");
            DropColumn("dbo.Справочник", "ТипЭнергииId");
        }
    }
}
