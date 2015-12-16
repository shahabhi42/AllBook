using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NewFakeBookMarkIII.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    //public class ApplicationUser : IdentityUser
    //{

    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    private DateTime _joined = DateTime.Now;
    //    public DateTime DateJoined { get { return _joined; } set { _joined = value; } }
    //    public virtual ICollection<Friend> Friends { get; set; }
    //    public virtual ICollection<Message> Messages { get; set; }
    //    public string Introduction { get; set; }
    //    public string Interest { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string Country { get; set; }
    //    //public DateTime Birthday { get; set; }
    //    public string Gender { get; set; }
    //    public virtual ICollection<Photo> Photos { get; set; }
    //    public virtual ICollection<Interest> Interests { get; set; }
    //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    //    {
    //        // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
    //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
    //        // Add custom user claims here
    //        return userIdentity;
    //    }
    //}

    public class ApplicationUser : IdentityUser
    {
        public virtual UserProfileInfo UserProfileInfo { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class UserProfileInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; }

        private DateTime _joined = DateTime.Now;
        public DateTime DateJoined { get { return _joined; } set { _joined = value; } }
        public virtual ICollection<Friend> Friends { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public string Introduction { get; set; }
        public string Interest { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        //public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<UserProfileInfo> UserProfileInfo { get; set; }
    }
}