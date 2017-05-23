using Castle.Windsor;
using Castle.Windsor.Installer;
using GeekStore.Infrastructure;
using GeekStore.UI.App_Start;
using GeekStore.UI.Windsor_Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace GeekStore.UI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
            var container = new WindsorContainer().Install(FromAssembly.This());
            var ioc = new ServiceLocator(container.Kernel, "GeekStoreConnectionString");
            ioc.RegisterAll();
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container.Kernel));
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.DefaultNamespaces.Add("GeekStore.UI.Controllers");
        }
    }
}