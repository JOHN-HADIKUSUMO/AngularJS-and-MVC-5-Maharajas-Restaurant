using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers
{
    [RoutePrefix("Reservation")]
    [AllowAnonymous]
    public class ReservationController : Base
    {
        public ReservationController(ILibrary library):base(library)
        {


        }

        [Route("")]
        public ActionResult Index(string category)
        {
            return View();
        }
    }
}