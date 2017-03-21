using GeekStore.Model;
using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.Interfaces;
using GeekStore.Repository.Implimentation;
using System;

namespace GeekStore.Service.Implimentation
{
    public class GeekStoreService : IGeekStoreService
    {
        IRepository _storage = new ListStorage();

        public void DeleteProductByID(int productID)
        {
            _storage.DeleteProductByID(productID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _storage.GetProducts();
        }

        public IEnumerable<Product> GetProductsByCriteria(Func<Product, bool> criteria)
        {
            return _storage.GetProductsByCriteria(criteria);
        }

        public void SaveProduct(Product product)
        {
            _storage.SaveProduct(product);
        }
    }
}
