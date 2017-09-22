using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gMVC1.Startup))]
namespace gMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
