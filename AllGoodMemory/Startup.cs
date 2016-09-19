using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllGoodMemory.Startup))]
namespace AllGoodMemory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
