using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewFakeBookMarkIII.Startup))]
namespace NewFakeBookMarkIII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
