using GeekStore.Domain.Model;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<T> GetByManufacturer<T>(string manufacturer) where T : Product;
        IEnumerable<T> GetByModel<T>(string model) where T : Product;
    }
}
