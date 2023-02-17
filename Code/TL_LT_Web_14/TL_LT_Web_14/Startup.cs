using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TL_LT_Web_14.Startup))]
namespace TL_LT_Web_14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
