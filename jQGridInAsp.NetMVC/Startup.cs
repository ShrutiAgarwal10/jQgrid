using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQGridInAsp.NetMVC.Startup))]
namespace jQGridInAsp.NetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
