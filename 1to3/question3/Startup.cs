using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(question3.Startup))]
namespace question3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
