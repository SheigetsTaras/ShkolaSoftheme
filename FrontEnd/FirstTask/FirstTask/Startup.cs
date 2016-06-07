using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstTask.Startup))]
namespace FirstTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
