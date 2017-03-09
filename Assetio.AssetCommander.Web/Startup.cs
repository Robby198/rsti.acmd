using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assetio.AssetCommander.Web.Startup))]
namespace Assetio.AssetCommander.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
