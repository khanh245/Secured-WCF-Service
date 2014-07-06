using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Secured_WCF_REST.Startup))]
namespace Secured_WCF_REST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
