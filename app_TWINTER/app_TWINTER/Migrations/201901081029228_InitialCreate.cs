namespace app_TWINTER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BIOs",
                c => new
                    {
                        BIO_Id = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 250),
                        Website = c.String(nullable: false, maxLength: 250),
                        DD = c.Int(nullable: false),
                        MM = c.Int(nullable: false),
                        YYYY = c.Int(nullable: false),
                        privacy = c.Int(),
                    })
                .PrimaryKey(t => t.BIO_Id);
            
            CreateTable(
                "dbo.Follows",
                c => new
                    {
                        Follower = c.Int(nullable: false),
                        Following = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Follower, t.Following });
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Twint_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Twint_Id, t.User_Id });
            
            CreateTable(
                "dbo.media",
                c => new
                    {
                        media_Id = c.Int(nullable: false, identity: true),
                        media_type = c.Int(),
                        URL = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.media_Id);
            
            CreateTable(
                "dbo.polls",
                c => new
                    {
                        poll_Id = c.Int(nullable: false, identity: true),
                        Nvariants = c.Int(nullable: false),
                        duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.poll_Id);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        poll_Id = c.Int(nullable: false),
                        order_Id = c.Int(nullable: false),
                        result = c.Int(nullable: false),
                        variant = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => new { t.poll_Id, t.order_Id });
            
            CreateTable(
                "dbo.Trandings",
                c => new
                    {
                        Tranding_Id = c.Int(nullable: false, identity: true),
                        Twint_Id = c.Int(nullable: false),
                        HashTag = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Tranding_Id);
            
            CreateTable(
                "dbo.Twints",
                c => new
                    {
                        Twint_Id = c.Int(nullable: false, identity: true),
                        msg = c.String(nullable: false, maxLength: 300),
                        Location = c.String(nullable: false, maxLength: 250),
                        media_Id = c.Int(),
                        poll_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Twint_Id);
            
            CreateTable(
                "dbo.UserBIOs",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        BIO_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.BIO_Id });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        User1 = c.String(nullable: false, maxLength: 50),
                        UPhoto = c.Binary(),
                        HeaderPhoto = c.Binary(),
                        password = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 90),
                        Role = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.User_Id);
            
            CreateTable(
                "dbo.UserTwints",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Twint_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Twint_Id });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTwints");
            DropTable("dbo.Users");
            DropTable("dbo.UserBIOs");
            DropTable("dbo.Twints");
            DropTable("dbo.Trandings");
            DropTable("dbo.Stats");
            DropTable("dbo.polls");
            DropTable("dbo.media");
            DropTable("dbo.Likes");
            DropTable("dbo.Follows");
            DropTable("dbo.BIOs");
        }
    }
}
