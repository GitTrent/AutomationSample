using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomationSampleProject.Startup))]
namespace AutomationSampleProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
