using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyStudentjob.Startup))]
namespace MyStudentjob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
