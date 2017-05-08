using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeekStore.Service.Mapping;
using GeekStore.UI.Mapping;
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