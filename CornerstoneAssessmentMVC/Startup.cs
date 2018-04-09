using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CornerstoneAssessmentMVC.Startup))]
namespace CornerstoneAssessmentMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
