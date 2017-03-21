using GeekStore.Model;
using System;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IRepository
    {
        void DeleteProductByID(int productID);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCriteria(Func<Product, bool> criteria);
        void SaveProduct(Product product);
    }
}
