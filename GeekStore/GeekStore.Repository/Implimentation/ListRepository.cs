using System.Collections.Generic;
using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;

namespace GeekStore.Repository.Implimentation
{
    public class ListRepository<T> : IRepository<T>
    {
        private static List<T> _products = new List<T>();

        public void DeleteProductsByCriteria(Func<T, bool> criteria) 
        {
            _products.Remove(_products.Where(criteria).Single());
        }

        public IEnumerable<T> GetProducts()
        {
            return _products;
        }

        public IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria)
        {
            return _products.Where(criteria);
        }

        public void SaveProduct(T product)
        {
            _products.Add(product);
        }
    }
}
