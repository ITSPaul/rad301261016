using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppRadWeek62.Startup))]
namespace ppRadWeek62
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
