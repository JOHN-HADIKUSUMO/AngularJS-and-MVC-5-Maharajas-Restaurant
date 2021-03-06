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
    public class Library:ILibrary
    {
        private IMenusLibrary menulib;
        private IPhotoMenusLibrary photomenulib;
        private IReservationsLibrary reservationlib;
        public Library(IMenusLibrary menulib,IPhotoMenusLibrary photomenulib,IReservationsLibrary reservationlib)
        {
            this.menulib = menulib;
            this.photomenulib = photomenulib;
            this.reservationlib = reservationlib;
        }

        public IMenusLibrary MenusLib
        {
            get
            {
                return this.menulib;
            }
            set
            {
                this.menulib = value;
            }
        }

        public IPhotoMenusLibrary PhotoMenusLib
        {
            get
            {
                return this.photomenulib;
            }
            set
            {
                this.photomenulib = value;
            }
        }


        public IReservationsLibrary ReservationsLib
        {
            get
            {
                return reservationlib;
            }
            set
            {
                reservationlib = value;
            }
        }
    }
}