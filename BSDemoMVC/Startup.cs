using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSDemoMVC.Startup))]
namespace BSDemoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
