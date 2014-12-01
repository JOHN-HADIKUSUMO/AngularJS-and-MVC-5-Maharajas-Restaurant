using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaharajaRestaurant.Startup))]
namespace MaharajaRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
