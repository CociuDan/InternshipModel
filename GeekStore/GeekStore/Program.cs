using System.Collections.Generic;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components;
using GeekStore.Model;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Interfaces;
using static System.Console;
using static GeekStore.Factory.CPUFactory;
using static GeekStore.Factory.DiskFactory;
using System.Xml.Linq;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> justAList = new List<Product>();
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));

            IGeekStoreService _geekStore_Service = new GeekStoreService();

            foreach (Product item in justAList)
            {
                _geekStore_Service.SaveProduct(item);
            }
            _geekStore_Service.SaveProduct(CreateCPU());
            _geekStore_Service.SaveProduct(CreateCPU());
            _geekStore_Service.SaveProduct(CreateCPU());
            _geekStore_Service.SaveProduct(CreateCPU());
            foreach (var item in _geekStore_Service.GetProducts<CPU>())
            {
                WriteLine(item.ToString());
            }
            ReadKey();
        }
    }
}
