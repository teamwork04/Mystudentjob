using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mystudentjob.ie.Startup))]
namespace Mystudentjob.ie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
