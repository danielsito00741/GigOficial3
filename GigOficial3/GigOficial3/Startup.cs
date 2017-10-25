using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigOficial3.Startup))]
namespace GigOficial3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
