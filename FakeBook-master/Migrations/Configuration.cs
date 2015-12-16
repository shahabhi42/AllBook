namespace NewFakeBookMarkIII.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewFakeBookMarkIII.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NewFakeBookMarkIII.Models.ApplicationDbContext context)
        {
            //var store = new UserStore<ApplicationUser>(context);
            //var manager = new UserManager<ApplicationUser>(store);
            //var hasher = new PasswordHasher();
            //var user = new ApplicationUser
            //{
            //    UserName = "testII",
            //    PasswordHash = hasher.HashPassword("P@ssword123"),
            //    UserProfileInfo = new UserProfileInfo
            //    {
            //        FirstName = "Test",
            //        LastName = "Two",
            //        Email = "Testtwo@yahoo.com"
            //    }
            //};

            //manager.Create(user, "testII");

        }
    }
}
