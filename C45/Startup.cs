using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C45.Startup))]
namespace C45
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
