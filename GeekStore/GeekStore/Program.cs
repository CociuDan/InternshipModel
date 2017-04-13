using System.Collections.Generic;
//using Ninject;
using GeekStore.Domain;
using GeekStore.Service.Interfaces;
using static System.Console;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain.Model.Components;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Infrastucture.IoC.RegisterAll();

            IRepository _geekStore_Repository = Infrastucture.IoC.Resolve<IRepository>();

            List<Product> justAList = new List<Product>();
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));

            foreach(var item in _geekStore_Repository.GetAll<Case>())
            {
                WriteLine(item.Model);
            }
            ReadKey();
            foreach (var item in _geekStore_Repository.GetAll<CPU>())
            {
                WriteLine(item.Model);
            }
            ReadKey();
        }
    }
}