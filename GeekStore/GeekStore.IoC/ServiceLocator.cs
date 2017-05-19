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
using Castle.MicroKernel;
using AutoMapper;
using GeekStore.Service.Mapping;
using Microsoft.AspNet.Identity;

namespace GeekStore.Infrastructure
{
    public class ServiceLocator
    {
        private readonly IKernel _kernel;
        private readonly string _connectionString;
        public ServiceLocator(IKernel kernel, string connectionString)
        {
            _connectionString = connectionString;
            _kernel = kernel;
        }

        public void RegisterAll()
        {
            NHibernateProvider provider = new NHibernateProvider(_connectionString);
            //Registering Services
            _kernel.Register(Component.For(typeof(IGenericService<CartDTO>)).ImplementedBy(typeof(GenericService<CartDTO, Cart>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<CaseDTO>)).ImplementedBy(typeof(GenericService<CaseDTO, Case>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IProductService<CaseDTO>)).ImplementedBy(typeof(ProductService<CaseDTO, Case>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<CoolerDTO>)).ImplementedBy(typeof(GenericService<CoolerDTO, Cooler>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<CPUDTO>)).ImplementedBy(typeof(GenericService<CPUDTO, CPU>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<DiskDTO>)).ImplementedBy(typeof(GenericService<DiskDTO, Disk>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<DisplayDTO>)).ImplementedBy(typeof(GenericService<DisplayDTO, Display>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<GPUDTO>)).ImplementedBy(typeof(GenericService<GPUDTO, GPU>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<HeadphonesDTO>)).ImplementedBy(typeof(GenericService<HeadphonesDTO, Headphones>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<KeyboardDTO>)).ImplementedBy(typeof(GenericService<KeyboardDTO, Keyboard>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<LaptopDTO>)).ImplementedBy(typeof(GenericService<LaptopDTO, Laptop>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<MonitorDTO>)).ImplementedBy(typeof(GenericService<MonitorDTO, Monitor>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<MotherboardDTO>)).ImplementedBy(typeof(GenericService<MotherboardDTO, Motherboard>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<MouseDTO>)).ImplementedBy(typeof(GenericService<MouseDTO, Mouse>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<PowerUnitDTO>)).ImplementedBy(typeof(GenericService<PowerUnitDTO, PowerUnit>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<RAMDTO>)).ImplementedBy(typeof(GenericService<RAMDTO, RAM>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IGenericService<SpeakersDTO>)).ImplementedBy(typeof(GenericService<SpeakersDTO, Speakers>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IUserService)).ImplementedBy(typeof(UserService)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IWarehouseProductService)).ImplementedBy(typeof(WarehouseProductService)).LifestylePerWebRequest());
            //Registering Repositories
            _kernel.Register(Component.For(typeof(IGenericRepository<>)).ImplementedBy(typeof(GenericRepository<>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IProductRepository<>)).ImplementedBy(typeof(ProductRepository<>)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IUserRepository)).ImplementedBy(typeof(UserRepository)).LifestylePerWebRequest());
            _kernel.Register(Component.For(typeof(IWarehouseProductRepository)).ImplementedBy(typeof(WarehouseProductRepository)).LifestylePerWebRequest());
            //Registering Default NHibernate Interfaces
            _kernel.Register(Component.For<ISessionFactory>().Instance(provider.SessionFactory).LifestyleSingleton());
            _kernel.Register(Component.For<ISession>().UsingFactory((ISessionFactory sessionFactory) => sessionFactory.OpenSession()).LifestylePerWebRequest());
            _kernel.Register(Component.For<ITransaction>().UsingFactory((ISession session) => session.BeginTransaction()).LifestylePerWebRequest());
        }

        public T Resolve<T>()
        {
            return _kernel.Resolve<T>();
        }

        //public static T Resolve<T>()
        //{
        //    return Container.Resolve<T>();
        //}





        //private static IoC instance = null;
        //private static readonly object padlock = new object();

        //private IoC() { }
        //public static IoC Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (padlock)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new IoC();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}

        //public override void Load()
        //{
        //    Bind<IGeekStoreService>().To<GeekStoreService>();
        //    Bind<IRepository>().To<DBRepository>();
        //    B
        //}
    }
}