using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.Custom;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.Custom
{
    public class CustomUserManager : UserManager<ApplicationUser>
    {
        private CustomUserStore customuserstore;
        public CustomUserManager(CustomUserStore customuserstore)
            : base(new CustomUserStore(new UserStore<ApplicationUser>(new MaharajasDbContext()), new MaharajasDbContext()))
        {
            this.customuserstore = customuserstore;
        }

        public CustomUserManager()
            : this(new CustomUserStore(new UserStore<ApplicationUser>(new MaharajasDbContext()), new MaharajasDbContext()))
        {

        }

        public override Task<IdentityResult> CreateAsync(ApplicationUser user, string password)
        {
            this.customuserstore.CreateAsync(user);
            return null;
        }

        public virtual Task<bool> FindByUsernameAsync(string username)
        {
            return this.customuserstore.FindByUsernameAsync(username);
        }

        public virtual Task<bool> FindByEmailAsync(string email)
        {
            return this.customuserstore.FindByEmailAsync(email);
        }
    }
}