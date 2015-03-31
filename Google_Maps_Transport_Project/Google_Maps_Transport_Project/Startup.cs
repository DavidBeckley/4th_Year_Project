using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Google_Maps_Transport_Project.Startup))]
namespace Google_Maps_Transport_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
