using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MaharajaRestaurant.DAL.Interfaces
{
    public interface IMaharajasDBContext
    {
        DbSet<Menu> Menus { get; set; }
        DbSet<PhotoMenu> PhotoMenus { get; set; }
        DbSet<Reservation> Reservations { get; set; }
    }
}
