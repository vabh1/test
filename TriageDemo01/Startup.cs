using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TriageDemo01.Startup))]
namespace TriageDemo01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
