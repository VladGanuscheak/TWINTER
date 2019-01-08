namespace app_TWINTER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Twints", "TwintVisibility", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Twints", "TwintVisibility");
        }
    }
}
