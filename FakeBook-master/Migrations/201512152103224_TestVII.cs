namespace NewFakeBookMarkIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestVII : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfileInfoes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfileInfoes", "Email", c => c.String());
        }
    }
}
