namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ДобавлениеПолянНаименованиеРесурсаВТаблицуРежимРаботыУстановки : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.РежимРаботыАгрегата", "НаименованиеРесурса", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.РежимРаботыАгрегата", "НаименованиеРесурса");
        }
    }
}
