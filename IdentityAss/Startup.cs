using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityAss.Startup))]
namespace IdentityAss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
