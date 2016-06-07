using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterWebUI.Startup))]
namespace ChatterWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
