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
    public class CustomUserStore_Test
    {
        private MaharajasDbContext context;
        public CustomUserStore_Test()
        {
            this.context = new MaharajasDbContext();
        }

        [TestMethod]
        public void FindByEmailAsync_Test()
        {
            CustomUserStore userstore = new CustomUserStore(new UserStore<ApplicationUser>(new MaharajasDbContext()), context);
            Task<bool> check = userstore.CheckByEmailAsync("happycustomer@maharajasrestaurant.com.au");

            Assert.IsTrue(check.Result);
        }

    }
}
