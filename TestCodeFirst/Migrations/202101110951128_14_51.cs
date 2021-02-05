namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _14_51 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.СиловойАгрегатВУстройстве", name: "ТехнологическоеУстройство_Id", newName: "ТехнологическоеУстройство_УстройствоId");
            RenameColumn(table: "dbo.Устройство", name: "Id", newName: "УстройствоId");
            RenameIndex(table: "dbo.Устройство", name: "IX_Id", newName: "IX_УстройствоId");
            RenameIndex(table: "dbo.СиловойАгрегатВУстройстве", name: "IX_ТехнологическоеУстройство_Id", newName: "IX_ТехнологическоеУстройство_УстройствоId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.СиловойАгрегатВУстройстве", name: "IX_ТехнологическоеУстройство_УстройствоId", newName: "IX_ТехнологическоеУстройство_Id");
            RenameIndex(table: "dbo.Устройство", name: "IX_УстройствоId", newName: "IX_Id");
            RenameColumn(table: "dbo.Устройство", name: "УстройствоId", newName: "Id");
            RenameColumn(table: "dbo.СиловойАгрегатВУстройстве", name: "ТехнологическоеУстройство_УстройствоId", newName: "ТехнологическоеУстройство_Id");
        }
    }
}
