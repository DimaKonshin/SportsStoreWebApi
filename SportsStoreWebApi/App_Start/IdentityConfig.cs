using Microsoft.Owin;
using Owin;

[assembly:OwinStartup(typeof(SportsStoreWebApi.IdentityConfig))]

namespace SportsStoreWebApi
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app) { }
    }
}