namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteing_id_columns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Устройство", "АгрегатID");
            DropColumn("dbo.Справочник", "ПланНормативныйТехнологическийID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Справочник", "ПланНормативныйТехнологическийID", c => c.Guid());
            AddColumn("dbo.Устройство", "АгрегатID", c => c.Guid());
        }
    }
}
