using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StrekMayor.Startup))]
namespace StrekMayor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
