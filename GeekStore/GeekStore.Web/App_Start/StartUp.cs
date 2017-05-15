using GeekStore.Infrastructure;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Interfaces;
using GeekStore.UI.App_Start;
using GeekStore.UI.Managers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
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

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Users/Login"),
            //    Provider = new CookieAuthenticationProvider
            //    {
            //        // Enables the application to validate the security stamp when the user logs in.
            //        // This is a security feature which is used when you change a password or add an external login to your account.  
            //        OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
            //            validateInterval: TimeSpan.FromMinutes(30),
            //            regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
            //    }
            //});
            //app.CreatePerOwinContext(() => new ApplicationUserManager());
            //app.CreatePerOwinContext<ApplicationSingInManager>((options, context) => new ApplicationSingInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication));

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Users/Login"),
            //    Provider = new CookieAuthenticationProvider()
            //});
        }
    }
}