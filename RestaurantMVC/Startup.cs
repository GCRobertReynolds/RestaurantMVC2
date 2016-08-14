using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantMVC.Startup))]
namespace RestaurantMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
