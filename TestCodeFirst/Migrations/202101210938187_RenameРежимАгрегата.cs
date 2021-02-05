namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameРежимАгрегата : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.РежимРаботыУстановки", newName: "РежимРаботыАгрегата");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.РежимРаботыАгрегата", newName: "РежимРаботыУстановки");
        }
    }
}
