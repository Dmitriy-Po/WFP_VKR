namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Устройство", newName: "Установка");
            RenameTable(name: "dbo.СиловойАгрегатВУстройстве", newName: "СиловойАгрегатВУстановке");
            RenameColumn(table: "dbo.СиловойАгрегатВУстановке", name: "ТехнологическоеУстройство_УстройствоId", newName: "ТехнологическаяУстановка_УстройствоId");
            RenameIndex(table: "dbo.СиловойАгрегатВУстановке", name: "IX_ТехнологическоеУстройство_УстройствоId", newName: "IX_ТехнологическаяУстановка_УстройствоId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.СиловойАгрегатВУстановке", name: "IX_ТехнологическаяУстановка_УстройствоId", newName: "IX_ТехнологическоеУстройство_УстройствоId");
            RenameColumn(table: "dbo.СиловойАгрегатВУстановке", name: "ТехнологическаяУстановка_УстройствоId", newName: "ТехнологическоеУстройство_УстройствоId");
            RenameTable(name: "dbo.СиловойАгрегатВУстановке", newName: "СиловойАгрегатВУстройстве");
            RenameTable(name: "dbo.Установка", newName: "Устройство");
        }
    }
}
