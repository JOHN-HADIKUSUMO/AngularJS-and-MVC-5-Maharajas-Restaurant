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

        [Route("Detail/{id}/{name}")]
        public ActionResult Detail(int id,string name)
        {
            ViewData["id"] = id;
            ViewData["url"] = Request.UrlReferrer == null ? "" : Request.UrlReferrer.AbsolutePath;
            return View();
        }
    }
}