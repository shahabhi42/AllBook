namespace NewFakeBookMarkIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        FriendID = c.Int(nullable: false, identity: true),
                        FriendName = c.String(),
                        DataFriended = c.DateTime(nullable: false),
                        UserProfileInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.FriendID)
                .ForeignKey("dbo.UserProfileInfoes", t => t.UserProfileInfo_Id)
                .Index(t => t.UserProfileInfo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friends", "UserProfileInfo_Id", "dbo.UserProfileInfoes");
            DropIndex("dbo.Friends", new[] { "UserProfileInfo_Id" });
            DropTable("dbo.Friends");
        }
    }
}
