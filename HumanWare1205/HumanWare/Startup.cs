using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HumanWare.Startup))]
namespace HumanWare
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
