using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AulaSiDDD.Web.Startup))]
namespace AulaSiDDD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
