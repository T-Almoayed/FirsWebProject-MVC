using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirsWebProject.Startup))]
namespace FirsWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
