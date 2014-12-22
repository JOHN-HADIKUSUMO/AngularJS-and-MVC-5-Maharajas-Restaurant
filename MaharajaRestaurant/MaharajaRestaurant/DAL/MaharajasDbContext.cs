using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;

namespace MaharajaRestaurant.DAL
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCodes { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }

    public class MaharajasDbContext : IdentityDbContext<ApplicationUser>, IMaharajasDBContext
    {
        public MaharajasDbContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<PhotoMenu> PhotoMenus { get; set; }
        //public DbSet<Test> Tests { get; set; }


    }
}