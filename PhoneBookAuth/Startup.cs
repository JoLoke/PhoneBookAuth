using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneBookAuth.Startup))]
namespace PhoneBookAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
