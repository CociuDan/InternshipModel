using GeekStore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GeekStore.Repository.Interfaces
{
    public interface IProductRepository<T> where T : Product
    {
        IEnumerable<T> GetByManufacturer(string manufacturer);
        IEnumerable<T> GetByModel(string model);
        IEnumerable<T> GetAllAvailablePaged(int page, int pageSize, Expression<Func<T, bool>> criteria);
    }
}