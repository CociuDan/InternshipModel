using System.Collections.Generic;
//using Ninject;
using GeekStore.Domain;
using GeekStore.Service.Interfaces;
using static System.Console;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Infrastucture.IoC.RegisterAll();

            IRepository _geekStore_Repository = Infrastucture.IoC.Resolve<IRepository>();

            //Cooler c = (Cooler)_geekStore_Repository.GetById<Cooler>(18);
            //_geekStore_Repository.Delete(c);
            //ReadKey();
            //foreach (var item in _geekStore_Repository.GetLaptopCpuGpuModels())
            //{
            //    WriteLine($"{item.LaptopModel} - {item.CpuModel} - {item.GpuModel}");
            //}
            foreach(var ceva in _geekStore_Repository.GetLaptops())
            {
                WriteLine(ceva);
            }
            ReadKey();
            //foreach (var item in _geekStore_Repository.GetAll<CPU>())
            //{
            //    WriteLine(item.Model);
            //}
            ReadKey();
        }
    }
}