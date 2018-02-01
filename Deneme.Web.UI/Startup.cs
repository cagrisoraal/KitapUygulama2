using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deneme.Web.UI.Startup))]
namespace Deneme.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
