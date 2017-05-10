using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Mapping;
using GeekStore.UI.Managers;
using GeekStore.UI.Mapping;
using Owin;
using System.Web.Mvc;

namespace GeekStore.UI.Windsor_Utils
{
    public class ControllerInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Installation configuration
        /// </summary>
        /// <param name="container"></param>
        /// <param name="store"></param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(FindControllers().LifestyleTransient());
            container.Register(Component.For<IMapper>().UsingFactoryMethod(x =>
            {
                return new MapperConfiguration(c =>
                {
                    c.AddProfile<ViewModelToDTOProfile>();
                    c.AddProfile<DTOToDomainEntityProfile>();
                }).CreateMapper();
            }));

            container.Register(Component.For<ApplicationSingInManager>().LifestylePerWebRequest());
            container.Register(Component.For<ApplicationUserManager>().LifestylePerWebRequest());
        }

        /// <summary>
        /// Find Controller classes
        /// </summary>
        /// <returns></returns>
        private static BasedOnDescriptor FindControllers()
        {
            return Classes.FromThisAssembly().BasedOn<IController>()
                          .If(t => t.Name.EndsWith("Controller"));
        }

    }
}