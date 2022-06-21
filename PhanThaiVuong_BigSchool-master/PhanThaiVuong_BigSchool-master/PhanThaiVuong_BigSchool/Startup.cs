using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhanThaiVuong_BigSchool.Startup))]
namespace PhanThaiVuong_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
