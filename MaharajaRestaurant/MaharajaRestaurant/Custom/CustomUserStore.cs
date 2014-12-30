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
    public class CustomUserStore : IUserStore<ApplicationUser>,IUserPasswordStore<ApplicationUser>
    {
        protected IUserStore<ApplicationUser> userstore;
        protected MaharajasDbContext context;
        public CustomUserStore(IUserStore<ApplicationUser> userstore,MaharajasDbContext context)
        {
            this.userstore = userstore;
            this.context = context;
        }

        public Task<bool> CheckByUsernameAsync(string username)
        {
            return Task.FromResult<bool>(this.context.Users.Where(w => w.UserName.Contains(username)).Any());
        }

        public Task<ApplicationUser> FindByUsernameAsync(string username)
        {
            return Task.FromResult<ApplicationUser>(this.context.Users.Where(w => w.UserName.Contains(username)).FirstOrDefault());
        }

        public Task<bool> CheckByEmailAsync(string email)
        {
            return Task.FromResult<bool>(this.context.Users.Where(w => w.Email.Contains(email)).Any());
        }

        public Task<ApplicationUser> FindByEmailAsync(string email)
        {
            return Task.FromResult<ApplicationUser>(this.context.Users.Where(w => w.Email.Contains(email)).FirstOrDefault());        
        }

        public Task CreateAsync(ApplicationUser user)
        {
            this.context.Users.Add(user);
            this.context.SaveChanges();
            return Task.FromResult<Object>(null);
        }

        public Task DeleteAsync(ApplicationUser user)
        {
            this.context.Users.Remove(user);
            this.context.SaveChanges();
            return Task.FromResult<Object>(null);
        }

        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            return Task.FromResult<ApplicationUser>(this.context.Users.Where(w => w.Id == userId).FirstOrDefault());
        }

        public Task<ApplicationUser> FindByNameAsync(string userName)
        {
            return Task.FromResult<ApplicationUser>(this.context.Users.Where(w => w.UserName == userName).FirstOrDefault());
        }

        public Task UpdateAsync(ApplicationUser user)
        {
            ApplicationUser tempUser = this.context.Users.Where(w => w.UserName == user.UserName).FirstOrDefault();
            if(tempUser !=null)
            {
                tempUser.Title = user.Title;
                tempUser.Firstname = user.Firstname;
                tempUser.Lastname = user.Lastname;
                tempUser.Mobile = user.Mobile;
                tempUser.Email = user.Email;
                tempUser.Street1 = user.Street1;
                tempUser.Street2 = user.Street2;
                tempUser.Suburb = user.Suburb;
                tempUser.State = user.State;
                tempUser.PostCodes = user.PostCodes;
                this.context.SaveChanges();
            }
            return Task.FromResult<Object>(null);
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser user)
        {
            ApplicationUser tempuser = this.context.Users.Where(w => w.UserName == user.UserName).FirstOrDefault();
            if(tempuser != null)
            {
                return Task<string>.FromResult(tempuser.PasswordHash);
            }

            throw new MemberAccessException("Invalid user.");
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user)
        {
            string password = GetPasswordHashAsync(user).Result;

            return Task<bool>.FromResult(String.IsNullOrEmpty(password));
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash)
        {
            ApplicationUser tempuser = this.context.Users.Where(w => w.UserName == user.UserName).FirstOrDefault();
            if(tempuser != null)
            {
                tempuser.PasswordHash = passwordHash;
                this.context.SaveChanges();
            }

            return Task.FromResult<Object>(null);
        }
    }
}