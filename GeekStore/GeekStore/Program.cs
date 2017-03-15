using System;
using System.Collections.Generic;
using GeekStore.Model.Components.Disks;
using GeekStore.Factory;
using GeekStore.Model;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Interfaces;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> justAList = new List<Product>();
            justAList.Add(new Product(CPUFactory.CreateCPU(), 300, 1));
            justAList.Add(new Product(CPUFactory.CreateCPU(), 400, 1));
            justAList.Add(new Product(CPUFactory.CreateCPU(), 500, 1));
            justAList.Add(new Product(CPUFactory.CreateCPU(), 600, 1));
            justAList.Add(new Product(DiskFactory.CreateSSD(), 80, 1));

            IGeekStoreService<Product> _geekStore_Service = new GeekStoreService<Product>();

            foreach(Product item in justAList)
            {
                _geekStore_Service.SaveItem(item);
            }

            foreach(var item in _geekStore_Service.GetItemByCriteria((product) => product.Price > 10 && product.Price < 550 && product.Item is Disk))
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("---------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
