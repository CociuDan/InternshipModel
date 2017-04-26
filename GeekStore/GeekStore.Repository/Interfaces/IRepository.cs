using GeekStore.Domain;
using GeekStore.Domain.CustomModel;
using GeekStore.Domain.Model.Components;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : Entity;
        Entity GetById<T>(int id) where T : Entity;
        void Save<T>(T item) where T : Entity;
        void Update<T>(T item) where T : Entity;
        void Delete<T>(T item) where T : Entity;














        IEnumerable<CPU> GetTOPCPUs();

        IEnumerable<string> GetLaptops();
        IEnumerable<LaptopCpuGpuModels> GetLaptopCpuGpuModels();
        //void DeleteProductsByCriteria(Func<T, bool> criteria);
        //IEnumerable<T> GetProducts();
        //IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria);
        //void SaveProduct(T product);
    }
}
