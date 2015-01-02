using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestMethod1()
        {
            MaharajasDbContext context = new MaharajasDbContext();
            var menutest = new MenusController(new Library(new MenusLibrary(context),new PhotoMenusLibrary(context),new ReservationsLibrary(context)));
            Task<outMenuList> tempmenulist = menutest.GetAll();
            Assert.IsNotNull(tempmenulist);
        }
    }
}
