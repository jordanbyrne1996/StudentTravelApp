using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentTravelApp.Startup))]
namespace StudentTravelApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
