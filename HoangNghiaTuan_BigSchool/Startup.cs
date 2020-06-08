using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangNghiaTuan_BigSchool.Startup))]
namespace HoangNghiaTuan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
