using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_2._2.Startup))]
namespace MVC_2._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
