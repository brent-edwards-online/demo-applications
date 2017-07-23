using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_Web_Demo.Startup))]
namespace EF_Web_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
