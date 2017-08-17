using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NFine.Site.Startup))]
namespace NFine.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
