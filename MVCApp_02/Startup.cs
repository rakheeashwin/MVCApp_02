using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApp_02.Startup))]
namespace MVCApp_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
