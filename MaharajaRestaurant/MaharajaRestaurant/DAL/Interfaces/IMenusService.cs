using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MaharajaRestaurant.DAL;


namespace MaharajaRestaurant.DAL.Interfaces
{
    public interface IMenusService:ICRAUD<Menu,int,bool>
    {
        IQueryable<Menu> ReadAll(MenusType menutype);
        Task<IQueryable<Menu>> ReadAllAsync(MenusType menutype);
    }
}