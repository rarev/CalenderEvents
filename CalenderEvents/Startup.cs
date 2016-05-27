using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalenderEvents.Startup))]
namespace CalenderEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
