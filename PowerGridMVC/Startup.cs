using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PowerGridMVC.Startup))]
namespace PowerGridMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
