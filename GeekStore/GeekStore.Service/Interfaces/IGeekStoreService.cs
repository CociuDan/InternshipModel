using GeekStore.Model;
using System;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGeekStoreService
    {
        void DeleteProductsByCriteria<T>(Func<T, bool> criteria);
        IEnumerable<T> GetProducts<T>();
        IEnumerable<T> GetProductsByCriteria<T>(Func<T, bool> criteria);
        void SaveProduct<T>(T product);
    }
}
