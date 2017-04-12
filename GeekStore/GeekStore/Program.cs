using System.Collections.Generic;
using Ninject;
using GeekStore.Domain;
using GeekStore.Service.Interfaces;
using static System.Console;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(IoC.IoC.Instance);
            IGeekStoreService _geekStore_Service = kernel.Get<IGeekStoreService>();

            List<Product> justAList = new List<Product>();
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));



            foreach (Product item in justAList)
            {
                _geekStore_Service.SaveProduct(item);
            }
            foreach (var item in _geekStore_Service.GetProducts<Product>())
            {
                WriteLine(item.ToString());
            }
            ReadKey();
        }
    }
}
