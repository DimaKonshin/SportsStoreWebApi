using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using SportsStoreWebApi.Infrastructure.Identity;

[assembly:OwinStartup(typeof(SportsStoreWebApi.IdentityConfig))]

namespace SportsStoreWebApi
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app) {
            app.CreatePerOwinContext<StoreIdentityDbContext>(StoreIdentityDbContext.Create);
            app.CreatePerOwinContext<StoreUserManager>(StoreUserManager.Create);
            app.CreatePerOwinContext<StoreRoleManager>(StoreRoleManager.Create);
        }
    }
}