namespace TestCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldУстройство : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Справочник", "УстройствоFK", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Справочник", "УстройствоFK");
        }
    }
}
