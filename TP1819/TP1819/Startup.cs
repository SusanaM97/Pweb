using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP1819.Startup))]
namespace TP1819
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
