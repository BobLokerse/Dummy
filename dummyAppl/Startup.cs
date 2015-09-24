using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dummyAppl.Startup))]
namespace dummyAppl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
