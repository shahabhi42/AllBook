namespace NewFakeBookMarkIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableTestIII : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfileInfoes", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfileInfoes", "UserName");
        }
    }
}
