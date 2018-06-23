using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelasRegionales.Startup))]
namespace TelasRegionales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
