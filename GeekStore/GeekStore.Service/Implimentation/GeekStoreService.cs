using GeekStore.Domain;
using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.Interfaces;
using GeekStore.Repository.Implimentation;
using System;

namespace GeekStore.Service.Implimentation
{
    public class GeekStoreService : IGeekStoreService
    {
        //public void DeleteProductsByCriteria<T>(Func<T, bool> criteria)
        //{
        //    IRepository<T> _storage = new ListRepository<T>();
        //    _storage.DeleteProductsByCriteria(criteria);
        //}

        //public IEnumerable<T> GetProducts<T>()
        //{
        //    IRepository<T> _storage = new ListRepository<T>();
        //    return _storage.GetProducts();
        //}

        //public IEnumerable<T> GetProductsByCriteria<T>(Func<T, bool> criteria)
        //{
        //    IRepository<T> _storage = new ListRepository<T>();
        //    return _storage.GetProductsByCriteria(criteria);
        //}

        //public void SaveProduct<T>(T product)
        //{
        //    IRepository<T> _storage = new ListRepository<T>();
        //    _storage.SaveProduct(product);
        //}
    }
}
