using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;


namespace MaharajaRestaurant.DAL.Interfaces
{
    public interface IMenusService:ICRAUD<Menu,int,bool>
    {
    }
}