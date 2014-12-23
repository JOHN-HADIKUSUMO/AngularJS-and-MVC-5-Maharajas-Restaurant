using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;


namespace MaharajaRestaurant.DAL.Interfaces
{
    public interface IReservationsService : ICRAUD<Reservation, int, bool>
    {

    }
}