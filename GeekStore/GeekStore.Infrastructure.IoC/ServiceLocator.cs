using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Infrastructure.IoC
{
    public static class ServiceLocator
    {
        private static IKernel _kernel;
        public static IKernel Kernel
        {
            set
            {
                _kernel = value;
            }
        }

        public static T Get<T>()
        {
            return _kernel.Resolve<T>();
        }
    }
}