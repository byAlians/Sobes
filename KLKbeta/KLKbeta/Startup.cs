using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KLKbeta.Startup))]
namespace KLKbeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
