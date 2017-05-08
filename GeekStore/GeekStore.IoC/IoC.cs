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

namespace GeekStore.Infrastructure
{
    public class IoC
    {
        private string _connectionString;
        public IoC(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegisterAll(IKernel kernel)
        {
            NHibernateProvider provider = new NHibernateProvider(_connectionString);
            //Registering Services
            kernel.Register(Component.For(typeof(IGenericService<CaseDTO>)).ImplementedBy(typeof(GenericService<CaseDTO, Case>)));
            kernel.Register(Component.For(typeof(IGenericService<CoolerDTO>)).ImplementedBy(typeof(GenericService<CoolerDTO, Cooler>)));
            kernel.Register(Component.For(typeof(IGenericService<CPUDTO>)).ImplementedBy(typeof(GenericService<CPUDTO, CPU>)));
            kernel.Register(Component.For(typeof(IGenericService<DiskDTO>)).ImplementedBy(typeof(GenericService<DiskDTO, Disk>)));
            kernel.Register(Component.For(typeof(IGenericService<DisplayDTO>)).ImplementedBy(typeof(GenericService<DisplayDTO, Display>)));
            kernel.Register(Component.For(typeof(IGenericService<GPUDTO>)).ImplementedBy(typeof(GenericService<GPUDTO, GPU>)));
            kernel.Register(Component.For(typeof(IGenericService<HeadphonesDTO>)).ImplementedBy(typeof(GenericService<HeadphonesDTO, Headphones>)));
            kernel.Register(Component.For(typeof(IGenericService<KeyboardDTO>)).ImplementedBy(typeof(GenericService<KeyboardDTO, Keyboard>)));
            kernel.Register(Component.For(typeof(IGenericService<LaptopDTO>)).ImplementedBy(typeof(GenericService<LaptopDTO, Laptop>)));
            kernel.Register(Component.For(typeof(IGenericService<MonitorDTO>)).ImplementedBy(typeof(GenericService<MonitorDTO, Monitor>)));
            kernel.Register(Component.For(typeof(IGenericService<MotherboardDTO>)).ImplementedBy(typeof(GenericService<MotherboardDTO, Motherboard>)));
            kernel.Register(Component.For(typeof(IGenericService<MouseDTO>)).ImplementedBy(typeof(GenericService<MouseDTO, Mouse>)));
            kernel.Register(Component.For(typeof(IGenericService<PowerUnitDTO>)).ImplementedBy(typeof(GenericService<PowerUnitDTO, PowerUnit>)));
            kernel.Register(Component.For(typeof(IGenericService<RAMDTO>)).ImplementedBy(typeof(GenericService<RAMDTO, RAM>)));
            kernel.Register(Component.For(typeof(IGenericService<SpeakersDTO>)).ImplementedBy(typeof(GenericService<SpeakersDTO, Speakers>)));
            kernel.Register(Component.For(typeof(IUserService)).ImplementedBy(typeof(UserService)));
            //Registering Repositories
            kernel.Register(Component.For(typeof(IGenericRepository<>)).ImplementedBy(typeof(GenericRepository<>)));
            kernel.Register(Component.For(typeof(IProductRepository)).ImplementedBy(typeof(ProductRepository)));
            kernel.Register(Component.For(typeof(IUserRepository)).ImplementedBy(typeof(UserRepository)));

            kernel.Register(Component.For<ISessionFactory>().Instance(provider.SessionFactory).LifestyleSingleton());
            kernel.Register(Component.For<ISession>().UsingFactory((ISessionFactory s) => s.OpenSession()).LifestylePerWebRequest());
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