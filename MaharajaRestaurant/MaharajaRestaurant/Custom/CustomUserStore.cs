using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaharajaRestaurant.DAL;

namespace MaharajaRestaurant.Custom
{
    public class CustomUserStore : IUserStore<ApplicationUser>
    {
        protected IUserStore<ApplicationUser> userstore;
        protected MaharajasDbContext context;
        public CustomUserStore(IUserStore<ApplicationUser> userstore,MaharajasDbContext context)
        {
            this.userstore = userstore;
            this.context = context;
        }

        public Task<bool> FindByUsernameAsync(string username)
        {
            return Task.FromResult<bool>(this.context.Users.Where(w => w.UserName.Contains(username)).Any());
        }

        public Task<bool> FindByEmailAsync(string email)
        {
            return Task.FromResult<bool>(this.context.Users.Where(w => w.Email.Contains(email)).Any());        
        }

        public Task CreateAsync(ApplicationUser user)
        {
            return this.userstore.CreateAsync(user);
        }

        public Task DeleteAsync(ApplicationUser user)
        {
            return this.userstore.DeleteAsync(user);
        }

        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            return this.userstore.FindByIdAsync(userId);
        }

        public Task<ApplicationUser> FindByNameAsync(string userName)
        {
            return this.userstore.FindByNameAsync(userName);
        }

        public Task UpdateAsync(ApplicationUser user)
        {
            return this.userstore.UpdateAsync(user);
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}