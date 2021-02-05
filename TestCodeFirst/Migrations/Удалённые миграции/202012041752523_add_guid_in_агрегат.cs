namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_guid_in_агрегат : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Устройство", "Id", "dbo.Справочник");
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство");
            DropIndex("dbo.СиловойАгрегатВУстройстве", new[] { "Агрегат_Id" });
            DropIndex("dbo.Устройство", new[] { "Id" });
            DropPrimaryKey("dbo.Устройство");
            AddColumn("dbo.Устройство", "ПланНормативныйТехнологический_Id", c => c.Int());
            AlterColumn("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", c => c.Guid());
            AlterColumn("dbo.Устройство", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Устройство", "Id");
            CreateIndex("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id");
            CreateIndex("dbo.Устройство", "ПланНормативныйТехнологический_Id");
            AddForeignKey("dbo.Устройство", "ПланНормативныйТехнологический_Id", "dbo.Справочник", "Id");
            AddForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство");
            DropForeignKey("dbo.Устройство", "ПланНормативныйТехнологический_Id", "dbo.Справочник");
            DropIndex("dbo.Устройство", new[] { "ПланНормативныйТехнологический_Id" });
            DropIndex("dbo.СиловойАгрегатВУстройстве", new[] { "Агрегат_Id" });
            DropPrimaryKey("dbo.Устройство");
            AlterColumn("dbo.Устройство", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", c => c.Int());
            DropColumn("dbo.Устройство", "ПланНормативныйТехнологический_Id");
            AddPrimaryKey("dbo.Устройство", "Id");
            CreateIndex("dbo.Устройство", "Id");
            CreateIndex("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id");
            AddForeignKey("dbo.СиловойАгрегатВУстройстве", "Агрегат_Id", "dbo.Устройство", "Id");
            AddForeignKey("dbo.Устройство", "Id", "dbo.Справочник", "Id");
        }
    }
}
