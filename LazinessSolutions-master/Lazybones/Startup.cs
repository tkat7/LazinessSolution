using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lazybones.Startup))]
namespace Lazybones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
