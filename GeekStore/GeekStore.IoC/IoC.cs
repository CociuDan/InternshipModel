//using Ninject.Modules;
using Microsoft.Practices.Unity;
using GeekStore.Repository.Interfaces;
using GeekStore.Repository.Implimentation;
using AutoMapper;
using GeekStore.Service.Mapping;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Models;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Domain.Model;
using GeekStore.UI.ViewModel;

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
            Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            Container.RegisterType(typeof(IGenericService<CaseViewModel>), typeof(GenericService<CaseViewModel, Case>));
            Container.RegisterType<IGenericService<CoolerViewModel>, GenericService<CoolerViewModel, Cooler>>();
            Container.RegisterType<IGenericService<CPUViewModel>, GenericService<CPUViewModel, CPU>>();
            Container.RegisterType<IGenericService<DiskViewModel>, GenericService<DiskViewModel, Disk>>();
            Container.RegisterType<IGenericService<DisplayViewModel>, GenericService<DisplayViewModel, Display>>();
            Container.RegisterType<IGenericService<GPUViewModel>, GenericService<GPUViewModel, GPU>>();
            Container.RegisterType<IGenericService<HeadphonesViewModel>, GenericService<HeadphonesViewModel, Headphones>>();
            Container.RegisterType<IGenericService<KeyboardViewModel>, GenericService<KeyboardViewModel, Keyboard>>();
            Container.RegisterType<IGenericService<LaptopViewModel>, GenericService<LaptopViewModel, Laptop>>();
            Container.RegisterType<IGenericService<MonitorViewModel>, GenericService<MonitorViewModel, Monitor>>();
            Container.RegisterType<IGenericService<MotherboardViewModel>, GenericService<MotherboardViewModel, Motherboard>>();
            Container.RegisterType<IGenericService<MouseViewModel>, GenericService<MouseViewModel, Mouse>>();
            Container.RegisterType<IGenericService<PowerUnitViewModel>, GenericService<PowerUnitViewModel, PowerUnit>>();
            //Container.RegisterType<IGenericService<IProduct>, GenericService<IProduct, Product>>();
            Container.RegisterType<IGenericService<RAMViewModel>, GenericService<RAMViewModel, RAM>>();
            Container.RegisterType<IGenericService<SpeakersViewModel>, GenericService<SpeakersViewModel, Speakers>>();
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