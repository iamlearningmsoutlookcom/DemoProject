using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication100.Startup))]
namespace WebApplication100
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
