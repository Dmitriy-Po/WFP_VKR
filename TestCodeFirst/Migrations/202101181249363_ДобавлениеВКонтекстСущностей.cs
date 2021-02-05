namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ДобавлениеВКонтекстСущностей : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ДневнаяНормаНаУстановку",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Норма = c.Decimal(nullable: false, precision: 18, scale: 2),
                        РежимРаботыFK = c.Int(nullable: false),
                        ТехнологическоеУстройствоFK = c.Int(nullable: false),
                        ПланПроизводстваПоДням_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ПланПроизводстваПоДням", t => t.ПланПроизводстваПоДням_Id)
                .Index(t => t.ПланПроизводстваПоДням_Id);
            
            CreateTable(
                "dbo.ПланПроизводстваПоДням",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        КаледнарныйДень = c.Int(nullable: false),
                        ПланПроизводстваПоМесяцам_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ПланПроизводстваПоМесяцам", t => t.ПланПроизводстваПоМесяцам_Id)
                .Index(t => t.ПланПроизводстваПоМесяцам_Id);
            
            CreateTable(
                "dbo.ПланПроизводстваПоМесяцам",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        КалендарныйГод = c.Int(nullable: false),
                        НаименованиеМесяца = c.String(maxLength: 50),
                        НомерМесяца = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ПланПроизводстваПоДням", "ПланПроизводстваПоМесяцам_Id", "dbo.ПланПроизводстваПоМесяцам");
            DropForeignKey("dbo.ДневнаяНормаНаУстановку", "ПланПроизводстваПоДням_Id", "dbo.ПланПроизводстваПоДням");
            DropIndex("dbo.ПланПроизводстваПоДням", new[] { "ПланПроизводстваПоМесяцам_Id" });
            DropIndex("dbo.ДневнаяНормаНаУстановку", new[] { "ПланПроизводстваПоДням_Id" });
            DropTable("dbo.ПланПроизводстваПоМесяцам");
            DropTable("dbo.ПланПроизводстваПоДням");
            DropTable("dbo.ДневнаяНормаНаУстановку");
        }
    }
}
