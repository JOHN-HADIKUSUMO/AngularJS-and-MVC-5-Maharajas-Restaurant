﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.DAL.Services;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Business
{
    public class ReservationsLibrary : ReservationsService, IReservationsLibrary
    {
        public ReservationsLibrary(IMaharajasDBContext dbcontext)
            : base(dbcontext)
        {

        }
    }
}