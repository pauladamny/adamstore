using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdamStore.Startup))]
namespace AdamStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
