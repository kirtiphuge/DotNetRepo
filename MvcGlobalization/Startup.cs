using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcGlobalization.Startup))]
namespace MvcGlobalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
