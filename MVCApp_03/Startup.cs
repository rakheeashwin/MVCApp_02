using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApp_03.Startup))]
namespace MVCApp_03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
