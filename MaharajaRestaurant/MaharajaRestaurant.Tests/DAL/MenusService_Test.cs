using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.DAL.Services;

namespace MaharajaRestaurant.Tests
{
    [TestClass]
    public class MenusService_Test
    {
        private MenusService service;
        public MenusService_Test()
        {
            this.service = new MenusService(new MaharajasDbContext());
        }

        [TestMethod]
        public void Create_Test()
        {
            Menu tempMenu = new Menu();
            tempMenu.Name = "Menu Test";
            tempMenu.Description = "Menu Test Description";
            tempMenu.Type = MenusType.Breads_and_Rice;
            tempMenu.Price = 6.80;
            tempMenu.WordAfterPrice = "small";
            int ret = service.Create(tempMenu);
            Assert.IsTrue(ret > 0);
        }

        [TestMethod]
        public void Delete_Test()
        {
            Menu tempMenu = service.ReadAll().Where(w => w.Name.Contains("Menu Test")).FirstOrDefault();
            bool ret = service.Delete(tempMenu.MenuID);
            Assert.IsTrue(ret);
        }
    }
}
