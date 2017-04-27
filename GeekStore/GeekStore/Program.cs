//using Ninject;
using static System.Console;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain.Model.Components;
using GeekStore.Service.Interfaces;
using GeekStore.UI.ViewModel;
using GeekStore.Service.Models;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Infrastucture.IoC.RegisterAll();

            IGenericRepository<Case> _caseRepository = Infrastucture.IoC.Resolve<IGenericRepository<Case>>();
            IGenericService<ICase> _genericService = Infrastucture.IoC.Resolve<IGenericService<ICase>>();

            // Order or = new Order();
            // or.OrderDate = DateTime.Now;
            // or.TotalPrice = 100;
            // or.User = HttpContext.CurrentUser;





            // User us = Cure
            //us.Orders.Add(or);
            // us.SaveOrUpdate();
























            //ReadKey();
            //Cooler c = (Cooler)_geekStore_Repository.GetById<Cooler>(18);
            //_geekStore_Repository.Delete(c);
            //ReadKey();
            //foreach (var item in _geekStore_Repository.GetLaptopCpuGpuModels())
            //{
            //    WriteLine($"{item.LaptopModel} - {item.CpuModel} - {item.GpuModel}");
            //}
            foreach (var compCase in _genericService.GetAllPaged(2, 3))
            {
                WriteLine(compCase.Model);
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