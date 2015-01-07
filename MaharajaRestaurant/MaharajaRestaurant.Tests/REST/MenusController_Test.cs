using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using MaharajaRestaurant;
using MaharajaRestaurant.Models.REST.Menu;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;
using MaharajaRestaurant.Controllers.REST;

namespace MaharajaRestaurant.Tests.REST
{
    [TestClass]
    public class MenusController_Test
    {
        [TestMethod]
        public void Get_Test()
        {
            MaharajasDbContext context = new MaharajasDbContext();
            var menutest = new MenusController(new Library(new MenusLibrary(context), new PhotoMenusLibrary(context), new ReservationsLibrary(context)));
            HttpResponseMessage response = menutest.Get(1);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetAll_Test()
        {
            MaharajasDbContext context = new MaharajasDbContext();
            var menutest = new MenusController(new Library(new MenusLibrary(context),new PhotoMenusLibrary(context),new ReservationsLibrary(context)));
            HttpResponseMessage response = menutest.GetAll("Breads_and_Rice");
            Assert.IsNotNull(response);
        }
    }
}
