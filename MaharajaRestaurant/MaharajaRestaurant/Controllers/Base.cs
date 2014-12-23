using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers
{
    public class Base : Controller
    {
        protected ILibrary library;
        public Base(ILibrary library)
        {
            this.library = library;
        }
    }
}