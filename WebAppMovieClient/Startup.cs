using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMovieClient.Startup))]
namespace WebAppMovieClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
