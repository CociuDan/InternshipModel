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

[assembly: OwinStartup(typeof(StartUp))]

namespace GeekStore.UI.App_Start
{
    public class StartUp
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    app.CreatePerOwinContext(() => new ApplicationUserManager());
        //    app.CreatePerOwinContext<ApplicationSingInManager>((options, context) => new ApplicationSingInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication));

        //    app.UseCookieAuthentication(new CookieAuthenticationOptions
        //    {
        //        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        //        LoginPath = new PathString("/Users/Login"),
        //        Provider = new CookieAuthenticationProvider()
        //    });
        //}
    }
}