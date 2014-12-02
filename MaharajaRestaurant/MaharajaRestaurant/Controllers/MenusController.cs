using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharajaRestaurant.Controllers
{
    [RoutePrefix("Menus")]
    [AllowAnonymous]
    public class MenusController : Controller
    {
        [Route("{category}")]
        public ActionResult Index(string category)
        {
            ViewData["Category"] = category.Replace("-", " ");
            return View();
        }
    }
}