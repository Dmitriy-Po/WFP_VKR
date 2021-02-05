namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameModePower : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ДневнаяНормаНаУстановку", name: "УстройствоРежимРесурс_РежимРаботыУстановкиId", newName: "УстройствоРежимРесурс_РежимРаботыАгрегатаId");
            RenameColumn(table: "dbo.УстройствоРежимРесурс", name: "РежимРаботыУстановкиId", newName: "РежимРаботыАгрегатаId");
            RenameIndex(table: "dbo.ДневнаяНормаНаУстановку", name: "IX_УстройствоРежимРесурс_РесурсId_УстройствоРежимРесурс_УстановкаId_УстройствоРежимРесурс_РежимРаботыУстановкиId", newName: "IX_УстройствоРежимРесурс_РесурсId_УстройствоРежимРесурс_УстановкаId_УстройствоРежимРесурс_РежимРаботыАгрегатаId");
            RenameIndex(table: "dbo.УстройствоРежимРесурс", name: "IX_РежимРаботыУстановкиId", newName: "IX_РежимРаботыАгрегатаId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.УстройствоРежимРесурс", name: "IX_РежимРаботыАгрегатаId", newName: "IX_РежимРаботыУстановкиId");
            RenameIndex(table: "dbo.ДневнаяНормаНаУстановку", name: "IX_УстройствоРежимРесурс_РесурсId_УстройствоРежимРесурс_УстановкаId_УстройствоРежимРесурс_РежимРаботыАгрегатаId", newName: "IX_УстройствоРежимРесурс_РесурсId_УстройствоРежимРесурс_УстановкаId_УстройствоРежимРесурс_РежимРаботыУстановкиId");
            RenameColumn(table: "dbo.УстройствоРежимРесурс", name: "РежимРаботыАгрегатаId", newName: "РежимРаботыУстановкиId");
            RenameColumn(table: "dbo.ДневнаяНормаНаУстановку", name: "УстройствоРежимРесурс_РежимРаботыАгрегатаId", newName: "УстройствоРежимРесурс_РежимРаботыУстановкиId");
        }
    }
}
