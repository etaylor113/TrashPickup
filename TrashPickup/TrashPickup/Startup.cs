using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashPickup.Models;

[assembly: OwinStartupAttribute(typeof(TrashPickup.Startup))]
namespace TrashPickup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }

        
    }
}