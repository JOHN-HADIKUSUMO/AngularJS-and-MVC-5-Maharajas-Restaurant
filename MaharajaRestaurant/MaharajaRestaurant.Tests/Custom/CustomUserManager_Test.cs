using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.Custom;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.DAL.Services;

namespace MaharajaRestaurant.Tests
{
    [TestClass]
    public class CustomUserManager_Test
    {
        public CustomUserManager_Test()
        {

        }

        [TestMethod]
        public void FindByEmailAsync_Test()
        {
            CustomUserManager usermanager = new CustomUserManager();
            Task<bool> check = usermanager.FindByEmailAsync("happycustomer@maharajasrestaurant.com.au");

            Assert.IsTrue(check.Result);
        }

    }
}
