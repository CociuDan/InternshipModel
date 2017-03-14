using GeekStore.Factory;
using GeekStore.Model.Components.CPUs;
using GeekStore.Model;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Interfaces;
using System;
using GeekStore.Model.Components.Motherboards;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeekStoreService<IItem> _geekStore_Service = new GeekStoreService();

            _geekStore_Service.SaveItem(CPUFactory.CreateDesktopCPU(3.40, 3.80, CPU.CPUCores.QuadCore, CPU.CPUManufacturer.Intel, "i7 2600", 50, "LGA1155", 95, 8));
            _geekStore_Service.SaveItem(ComputerFactory.CreateLaptop());
            _geekStore_Service.SaveItem(GPUFactory.CreateDesktopGPU());
            _geekStore_Service.SaveItem(CPUFactory.CreateDesktopCPU());
            _geekStore_Service.SaveItem(CPUFactory.CreateDesktopCPU());

            var cpusUnderAThousand = _geekStore_Service.GetItemsByPrice<DesktopCPU>(300, 1000);

            foreach (var item in cpusUnderAThousand)
            {
                Console.WriteLine(item.Description);
                Console.WriteLine("-------------------------------------------");
            }
            Console.ReadKey();

            _geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard());
            _geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard("Z270", "MSI", "Gaming Carbon", 2, 200.0, 4, "LGA1151"));
            _geekStore_Service.SaveItem(MotherboardFactory.CreateDesktopMotherboard());
            

            var compatibleItems = _geekStore_Service.GetItemByCriteria((item) => { return item.Price > 0 && item.Price < 100 && item is DesktopCPU; });


            //foreach (var item in compatibleItems)
            //{
            //    Console.WriteLine(item.Description);
            //    Console.WriteLine("-------------------------------------------");
            //}
            Console.ReadKey();
        }
    }
}
