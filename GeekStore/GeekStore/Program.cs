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

            //var cpusUnderAThousand = _geekStore_Service.GetItemsByPrice<DesktopCPU>(300, 1000);

            //foreach (var item in cpusUnderAThousand)
            //{
            //    Console.WriteLine(item.Description);
            //    Console.WriteLine("-------------------------------------------");
            //}

            //_geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard());
            //_geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard("Z270", "MSI", "Gaming Carbon", 2, 200.0, 4, "LGA1151"));
            //_geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard());


            //var compatibleItems = _geekStore_Service.GetItemByCriteria((item) => { return item.Price > 0 && item.Price < 100 && item is DesktopCPU; });

            ////foreach (var item in compatibleItems)
            ////{
            ////    Console.WriteLine(item.Description);
            ////    Console.WriteLine("-------------------------------------------");
            ////}
            //Console.ReadKey();
        }
    }
}
