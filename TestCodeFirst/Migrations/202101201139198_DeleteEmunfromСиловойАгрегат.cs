namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteEmunfromСиловойАгрегат : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.СиловойАгрегатВУстройстве", "СправочникРесурсов_Id", c => c.Int());
            CreateIndex("dbo.СиловойАгрегатВУстройстве", "СправочникРесурсов_Id");
            AddForeignKey("dbo.СиловойАгрегатВУстройстве", "СправочникРесурсов_Id", "dbo.СправочникРесурсов", "Id");
            //DropColumn("dbo.СиловойАгрегатВУстройстве", "ТипЭнергии");
        }
        
        public override void Down()
        {
           //AddColumn("dbo.СиловойАгрегатВУстройстве", "ТипЭнергии", c => c.Int(nullable: false));
            DropForeignKey("dbo.СиловойАгрегатВУстройстве", "СправочникРесурсов_Id", "dbo.СправочникРесурсов");
            DropIndex("dbo.СиловойАгрегатВУстройстве", new[] { "СправочникРесурсов_Id" });
            DropColumn("dbo.СиловойАгрегатВУстройстве", "СправочникРесурсов_Id");
        }
    }
}
