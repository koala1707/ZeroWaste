using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoWastes.Startup))]
namespace NoWastes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
