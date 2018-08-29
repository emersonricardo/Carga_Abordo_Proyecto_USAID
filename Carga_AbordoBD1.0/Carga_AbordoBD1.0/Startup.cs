using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carga_AbordoBD1._0.Startup))]
namespace Carga_AbordoBD1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
