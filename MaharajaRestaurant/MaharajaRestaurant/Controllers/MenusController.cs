using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers
{
    [RoutePrefix("Menus")]
    [AllowAnonymous]
    public class MenusController : Base
    {
        public MenusController(ILibrary library)
            : base(library)
        {

        }
        [Route("{category?}")]
        public ActionResult Index(string category = "")
        {
            ViewData["BreadCrumb"] = category.Replace("-", " ");
            ViewData["Category"] = category.Replace("-", "_");
            return View();
        }
    }
}