using GeekStore.UI.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;

[assembly: OwinStartup(typeof(StartUp))]

namespace GeekStore.UI.App_Start
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Users/Login"),
                ExpireTimeSpan = new TimeSpan(0, 5, 0)                
            });
        }
    }
}