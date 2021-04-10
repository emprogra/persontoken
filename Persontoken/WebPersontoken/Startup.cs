using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPersontoken.Startup))]
namespace WebPersontoken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
