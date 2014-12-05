using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace MaharajaRestaurant.DAL
{
    public class MaharajasDBContext:DbContext
    {

        public MaharajasDBContext():base("DefaultConnection")
        {

        }

        public DbSet<Menu> Menus { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}