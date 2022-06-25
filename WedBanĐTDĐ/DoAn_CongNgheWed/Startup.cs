using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAn_CongNgheWed.Startup))]
namespace DoAn_CongNgheWed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
