using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resturanto.Startup))]
namespace Resturanto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
