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

        public Task<bool> CreateAsync(ApplicationUser user,string email, string password)
        {
            user.Email = email;
            user.PasswordHash = PasswordHasher.HashPassword(password);
            user.SecurityStamp = Guid.NewGuid().ToString();
            IdentityUserRole role = new IdentityUserRole();
            this.customuserstore.CreateAsync(user);

            Task<ApplicationUser> tempuser = this.customuserstore.FindByNameAsync(user.UserName);

            if(tempuser != null)
            {
                IdentityUserRole temprole =  new IdentityUserRole();
                temprole.UserId = tempuser.Result.Id;
                temprole.RoleId = "6f1345dd-26f6-4967-a326-c227b8d8b2df";/* Hard coded */
                tempuser.Result.Roles.Add(temprole);
                this.customuserstore.UpdateAsync(tempuser.Result);
            }

            return Task.FromResult<bool>(true);
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