using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankingWebsite.Startup))]
namespace BankingWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
