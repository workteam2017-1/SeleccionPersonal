using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormSeleccionPersonal.Startup))]
namespace FormSeleccionPersonal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
