using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Carry_InService.Startup))]

namespace Carry_InService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}