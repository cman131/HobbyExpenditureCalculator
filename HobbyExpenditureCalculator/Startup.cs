using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HobbyExpenditureCalculator.Startup))]
namespace HobbyExpenditureCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
