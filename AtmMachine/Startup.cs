using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtmMachine.Startup))]
namespace AtmMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
