using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.Models;
using MaharajaRestaurant.Models.REST.Reservation;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers.REST
{
    public class Base : ApiController
    {
        protected ILibrary library;
        public Base(ILibrary library)
        {
            this.library = library;
        }
    }
}
