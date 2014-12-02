using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationController.Controllers
{
    [RoutePrefix("Reservation")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        [Route("")]
        public ActionResult Index(string category)
        {
            return View();
        }
    }
}