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
        private IdentityDbContext dbcontext;
        private CustomUserStore customuserstore;
        public CustomUserManager(CustomUserStore customuserstore, IdentityDbContext dbcontext)
            : base(new CustomUserStore(new UserStore<ApplicationUser>(new MaharajasDbContext()), new MaharajasDbContext()))
        {
            this.dbcontext = dbcontext;
            this.customuserstore = customuserstore;
        }

        public CustomUserManager()
            : this(new CustomUserStore(new UserStore<ApplicationUser>(new MaharajasDbContext()), new MaharajasDbContext()), new IdentityDbContext())
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
                string roleid = dbcontext.Roles.Where(w => w.Name == "CUSTOMER").Select(s => s.Id).FirstOrDefault<string>();
                IdentityUserRole temprole =  new IdentityUserRole();
                temprole.UserId = tempuser.Result.Id;
                temprole.RoleId = roleid;
                tempuser.Result.Roles.Add(temprole);
                this.customuserstore.UpdateAsync(tempuser.Result);
            }

            return Task.FromResult<bool>(true);
        }

        public virtual Task<bool> CheckByUsernameAsync(string username)
        {
            return this.customuserstore.CheckByUsernameAsync(username);
        }

        public virtual Task<ApplicationUser> FindByUsernameAsync(string username)
        {
            return this.customuserstore.FindByUsernameAsync(username);
        }

        public virtual Task<bool> CheckByEmailAsync(string email)
        {
            return this.customuserstore.CheckByEmailAsync(email);
        }

        public virtual Task<ApplicationUser> FindByEmailAsync(string email)
        {
            return this.customuserstore.FindByEmailAsync(email);
        }
    }
}