namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDeleteCascade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", "dbo.ПланПроизводстваПоМесяцам");
            DropIndex("dbo.ПланПроизводстваПоДням", new[] { "ПланПроизводстваПоМесяцам_Id" });
            AlterColumn("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id");
            AddForeignKey("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", "dbo.ПланПроизводстваПоМесяцам", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", "dbo.ПланПроизводстваПоМесяцам");
            DropIndex("dbo.ПланПроизводстваПоДням", new[] { "ПланПроизводстваПоМесяцам_Id" });
            AlterColumn("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", c => c.Int());
            CreateIndex("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id");
            AddForeignKey("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", "dbo.ПланПроизводстваПоМесяцам", "Id");
        }
    }
}
