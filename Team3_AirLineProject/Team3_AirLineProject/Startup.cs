using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team3_AirLineProject.Startup))]
namespace Team3_AirLineProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
