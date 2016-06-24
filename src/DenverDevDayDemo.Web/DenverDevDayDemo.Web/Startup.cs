using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DenverDevDayDemo.Web.Startup))]
namespace DenverDevDayDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
