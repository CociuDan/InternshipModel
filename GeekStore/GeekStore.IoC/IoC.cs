//using Ninject.Modules;
using Microsoft.Practices.Unity;
using GeekStore.Repository.Interfaces;
using GeekStore.Repository.Implimentation;
using AutoMapper;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Implimentation;
using GeekStore.Service.DTO;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Domain.Model;
using GeekStore.Infrastructure;

namespace GeekStore.Infrastucture
{
    public sealed class IoC// : NinjectModule
    {
        private static readonly UnityContainer Container;

        static IoC()
        {
            if (Container == null)
            {
                Container = new UnityContainer();
            }
        }

        public static void RegisterAll()
        {
            //Registering Services
            Container.RegisterType(typeof(IGenericService<CaseDTO>), typeof(GenericService<CaseDTO, Case>));
            Container.RegisterType(typeof(IGenericService<CoolerDTO>), typeof(GenericService<CoolerDTO, Cooler>));
            Container.RegisterType(typeof(IGenericService<CPUDTO>), typeof(GenericService<CPUDTO, CPU>));
            Container.RegisterType(typeof(IGenericService<DiskDTO>), typeof(GenericService<DiskDTO, Disk>));
            Container.RegisterType(typeof(IGenericService<DisplayDTO>), typeof(GenericService<DisplayDTO, Display>));
            Container.RegisterType(typeof(IGenericService<GPUDTO>), typeof(GenericService<GPUDTO, GPU>));
            Container.RegisterType(typeof(IGenericService<HeadphonesDTO>), typeof(GenericService<HeadphonesDTO, Headphones>));
            Container.RegisterType(typeof(IGenericService<KeyboardDTO>), typeof(GenericService<GPUDTO, GPU>));
            Container.RegisterType(typeof(IGenericService<LaptopDTO>), typeof(GenericService<LaptopDTO, Laptop>));
            Container.RegisterType(typeof(IGenericService<MonitorDTO>), typeof(GenericService<MonitorDTO, Monitor>));
            Container.RegisterType(typeof(IGenericService<MotherboardDTO>), typeof(GenericService<MotherboardDTO, Motherboard>));
            Container.RegisterType(typeof(IGenericService<MouseDTO>), typeof(GenericService<MouseDTO, Mouse>));
            Container.RegisterType(typeof(IGenericService<PowerUnitDTO>), typeof(GenericService<PowerUnitDTO, PowerUnit>));
            Container.RegisterType(typeof(IGenericService<RAMDTO>), typeof(GenericService<RAMDTO, RAM>));
            Container.RegisterType(typeof(IGenericService<SpeakersDTO>), typeof(GenericService<SpeakersDTO, Speakers>));
            //Registering Repositories
            Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            Container.RegisterType<IProductRepository, ProductRepository>();

            Container.RegisterInstance(NHibernateProvider.GetSession());


            var mapperConfig = new MapperConfiguration(config => config.AddProfile<CommonProfile>());
            mapperConfig.AssertConfigurationIsValid();
            Container.RegisterType<IMapper>(new InjectionFactory(c => mapperConfig.CreateMapper()));
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }





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