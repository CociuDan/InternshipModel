﻿using Castle.Windsor;
using Castle.Windsor.Installer;
using GeekStore.Infrastucture;
using GeekStore.UI.App_Start;
using GeekStore.UI.Windsor_Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace GeekStore.UI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var container = new WindsorContainer().Install(FromAssembly.This());
            var ioc = new IoC("GeekStoreConnectionString");
            ioc.RegisterAll(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container.Kernel));
        }
    }
}