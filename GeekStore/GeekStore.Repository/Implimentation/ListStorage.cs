using System.Collections.Generic;
using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;

namespace GeekStore.Repository.Implimentation
{
    public class ListStorage : IRepository
    {
        List<Product> _products = new List<Product>();

        public void DeleteProductByID(int productID)
        {
            _products.Remove(_products.Where(x => x.ID == productID).First());
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IEnumerable<Product> GetProductsByCriteria(Func<Product, bool> criteria)
        {
            return _products.Where(criteria);
        }

        public void SaveProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
