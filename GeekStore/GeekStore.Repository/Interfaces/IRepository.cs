using GeekStore.Domain;
using GeekStore.Domain.Model.Components;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : Item;
        //void DeleteProductsByCriteria(Func<T, bool> criteria);
        //IEnumerable<T> GetProducts();
        //IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria);
        //void SaveProduct(T product);
    }
}
