namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDeleteCascadeДневнаяНорма : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", "dbo.ПланПроизводстваПоДням");
            DropIndex("dbo.ДневнаяНормаНаУстановку", new[] { "ПланПроизводстваПоДням_Id" });
            AlterColumn("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id");
            AddForeignKey("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", "dbo.ПланПроизводстваПоДням", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", "dbo.ПланПроизводстваПоДням");
            DropIndex("dbo.ДневнаяНормаНаУстановку", new[] { "ПланПроизводстваПоДням_Id" });
            AlterColumn("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", c => c.Int());
            CreateIndex("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id");
            AddForeignKey("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", "dbo.ПланПроизводстваПоДням", "Id");
        }
    }
}
