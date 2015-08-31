using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplications.Startup))]
namespace WebApplications
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
