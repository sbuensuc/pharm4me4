using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pharm4me4.Startup))]
namespace pharm4me4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
