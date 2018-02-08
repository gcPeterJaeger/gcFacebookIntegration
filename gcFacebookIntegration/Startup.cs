using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gcFacebookIntegration.Startup))]
namespace gcFacebookIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
