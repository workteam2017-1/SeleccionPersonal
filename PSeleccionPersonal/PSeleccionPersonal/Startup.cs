using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSeleccionPersonal.Startup))]
namespace PSeleccionPersonal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
