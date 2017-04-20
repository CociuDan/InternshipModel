using GeekStore.Domain;
using GeekStore.Domain.CustomModel;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : Item;
        Item GetById<T>(int id) where T : Item;
        void Save<T>(T item) where T : Item;
        void Update<T>(T item);
        void Delete<T>(T item);
        IEnumerable<T> GetByManufacturer<T>(string manufacturer) where T : Product;
        IEnumerable<T> GetByModel<T>(string model) where T : Product;
        IEnumerable<CPU> GetTOPCPUs();

        IEnumerable<string> GetLaptops();
        IEnumerable<LaptopCpuGpuModels> GetLaptopCpuGpuModels();
        //void DeleteProductsByCriteria(Func<T, bool> criteria);
        //IEnumerable<T> GetProducts();
        //IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria);
        //void SaveProduct(T product);
    }
}
