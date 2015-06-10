using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XHLH.Startup))]
namespace XHLH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
