using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JwelleryShop.Startup))]
namespace JwelleryShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
