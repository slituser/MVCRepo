using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitProject.Startup))]
namespace GitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
