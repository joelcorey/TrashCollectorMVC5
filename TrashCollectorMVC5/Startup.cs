using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollectorMVC5.Startup))]
namespace TrashCollectorMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
