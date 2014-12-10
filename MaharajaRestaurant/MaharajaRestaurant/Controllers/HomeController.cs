using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

namespace MaharajaRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private ILibrary library;
        public HomeController(ILibrary library)
        {
            this.library = library;
        }

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            //Menu test = library.MenusLib.Read(1);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}