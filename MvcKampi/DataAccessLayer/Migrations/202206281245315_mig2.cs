namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Headings", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
