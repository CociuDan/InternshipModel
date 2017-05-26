using GeekStore.Repository.Interfaces;
using GeekStore.Repository.Implimentation;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Implimentation;
using GeekStore.Service.DTO;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Domain.Model;
using NHibernate;
using Castle.MicroKernel.Registration;
using GeekStore.Domain.Model.PCs;
using GeekStore.Infrastructure.NHibernate;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace GeekStore.Infrastructure.IoC
{
    public class ServiceModule : IWindsorInstaller
    {
        private readonly string _connectionString;
        public ServiceModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            NHibernateProvider provider = new NHibernateProvider(_connectionString);
            //Registering Services
            container.Register(Component.For(typeof(IGenericService<CaseDTO>)).ImplementedBy(typeof(GenericService<CaseDTO, Case>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IProductService<CaseDTO>)).ImplementedBy(typeof(ProductService<CaseDTO, Case>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<CoolerDTO>)).ImplementedBy(typeof(GenericService<CoolerDTO, Cooler>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<CPUDTO>)).ImplementedBy(typeof(GenericService<CPUDTO, CPU>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<DesktopDTO>)).ImplementedBy(typeof(GenericService<DesktopDTO, Desktop>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<DiskDTO>)).ImplementedBy(typeof(GenericService<DiskDTO, Disk>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<DisplayDTO>)).ImplementedBy(typeof(GenericService<DisplayDTO, Display>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<GPUDTO>)).ImplementedBy(typeof(GenericService<GPUDTO, GPU>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<HeadphonesDTO>)).ImplementedBy(typeof(GenericService<HeadphonesDTO, Headphones>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<KeyboardDTO>)).ImplementedBy(typeof(GenericService<KeyboardDTO, Keyboard>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<LaptopDTO>)).ImplementedBy(typeof(GenericService<LaptopDTO, Laptop>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<MonitorDTO>)).ImplementedBy(typeof(GenericService<MonitorDTO, Monitor>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<MotherboardDTO>)).ImplementedBy(typeof(GenericService<MotherboardDTO, Motherboard>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<MouseDTO>)).ImplementedBy(typeof(GenericService<MouseDTO, Mouse>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<PowerUnitDTO>)).ImplementedBy(typeof(GenericService<PowerUnitDTO, PowerUnit>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<RAMDTO>)).ImplementedBy(typeof(GenericService<RAMDTO, RAM>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IGenericService<SpeakersDTO>)).ImplementedBy(typeof(GenericService<SpeakersDTO, Speakers>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IUserService)).ImplementedBy(typeof(UserService)).LifestylePerWebRequest());
            //container.Register(Component.For(typeof(IWarehouseProductService)).ImplementedBy(typeof(WarehouseProductService)).LifestylePerWebRequest());
            //Registering Repositories
            container.Register(Component.For(typeof(IGenericRepository<>)).ImplementedBy(typeof(GenericRepository<>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IProductRepository<>)).ImplementedBy(typeof(ProductRepository<>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IUserRepository)).ImplementedBy(typeof(UserRepository)).LifestylePerWebRequest());
            //container.Register(Component.For(typeof(IWarehouseProductRepository)).ImplementedBy(typeof(WarehouseProductRepository)).LifestylePerWebRequest());
            //Registering Default NHibernate Interfaces
            container.Register(Component.For<ISessionFactory>().Instance(provider.SessionFactory).LifestyleSingleton());
            container.Register(Component.For<ISession>().UsingFactory((ISessionFactory sessionFactory) => sessionFactory.OpenSession()).LifestylePerWebRequest());
            container.Register(Component.For<ITransaction>().UsingFactory((ISession session) => session.BeginTransaction()).LifestylePerWebRequest());
        }
    }
}