using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSAC_Voronov_Chekushin.Startup))]
namespace BSAC_Voronov_Chekushin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
