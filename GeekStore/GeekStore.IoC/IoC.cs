//using Ninject.Modules;
using Microsoft.Practices.Unity;
using GeekStore.Repository.Interfaces;
using GeekStore.Repository.Implimentation;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Implimentation;

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
            Container.RegisterType<IGeekStoreService, GeekStoreService>();
            Container.RegisterType<IRepository, GenericRepository>();
            Container.RegisterType<IProductRepository, ProductRepository>();
            Container.RegisterInstance(NHibernateProvider.GetSession());
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
