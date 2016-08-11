using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Weacts.Startup))]
namespace Weacts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
