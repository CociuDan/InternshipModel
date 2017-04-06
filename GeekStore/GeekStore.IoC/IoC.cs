using Ninject.Modules;
using GeekStore.Repository.Interfaces;
using GeekStore.Repository.Implimentation;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Implimentation;

namespace GeekStore.IoC
{
    public sealed class IoC : NinjectModule
    {
        private static IoC instance = null;
        private static readonly object padlock = new object();

        private IoC() { }
        public static IoC Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new IoC();
                        }
                    }
                }
                return instance;
            }
        }

        public override void Load()
        {
            Bind<IGeekStoreService>().To<GeekStoreService>();
            Bind(typeof(IRepository<>)).To(typeof(ListStorage<>));
        }
    }
}
