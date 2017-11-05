using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Produccion.Backend.Startup))]
namespace Produccion.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
