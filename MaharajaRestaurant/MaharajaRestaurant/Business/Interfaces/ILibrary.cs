using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;


namespace MaharajaRestaurant.Business.Interfaces
{
    public interface ILibrary
    {
        IMenusLibrary MenusLib { get; set; }
        IPhotoMenusLibrary PhotoMenusLib { get; set; }

        IReservationsLibrary ReservationsLib { get; set; }
    }
}
