using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Motivational.Startup))]
namespace Motivational
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
