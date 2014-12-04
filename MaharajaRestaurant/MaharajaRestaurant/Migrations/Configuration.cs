namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MaharajaRestaurant.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MaharajaRestaurant.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MaharajaRestaurant.Models.ApplicationDbContext";
        }

        protected override void Seed(MaharajaRestaurant.Models.ApplicationDbContext context)
        {
            /* To Seed Administrator Role */
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };
                manager.Create(role);
            }

            /* To Seed Customer Role */
            if (!context.Roles.Any(r => r.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
                manager.Create(role);
            }

            /* To Seed Administrator User Account and Its Role */
            if (!context.Users.Any(u => u.UserName == "Administrator"))
            {
                PasswordHasher hasher = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Administrator", PasswordHash = hasher.HashPassword("asdQWE!@#"), Title = "Mr", Firstname = "John", Lastname = "Doe", Email = "maharajas@miniadverts.com.au" };
                manager.Create(user, "Administrator");
                manager.AddToRole(user.Id, "Administrator");
            }

            /* To Seed Administrator User Account and Its Role */
            if (!context.Users.Any(u => u.UserName == "happycustomer"))
            {
                PasswordHasher hasher = new PasswordHasher();
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "happycustomer", PasswordHash = hasher.HashPassword("asdQWE!@#"), Title = "Mr", Firstname = "Happy", Lastname = "Customer", Email = "happycustomer@miniadverts.com.au" };
                manager.Create(user, "happycustomer");
                manager.AddToRole(user.Id, "Customer");
            }

        }
    }
}
