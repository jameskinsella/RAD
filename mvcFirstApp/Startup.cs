using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcFirstApp.Startup))]
namespace mvcFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
