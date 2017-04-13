using GeekStore.Domain.Model.Components;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<CPU> GetCPUs();
        //void DeleteProductsByCriteria(Func<T, bool> criteria);
        //IEnumerable<T> GetProducts();
        //IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria);
        //void SaveProduct(T product);
    }
}
