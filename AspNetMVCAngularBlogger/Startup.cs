using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetMVCAngularBlogger.Startup))]
namespace AspNetMVCAngularBlogger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
