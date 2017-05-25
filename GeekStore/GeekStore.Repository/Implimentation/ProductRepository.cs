using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using NHibernate;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace GeekStore.Repository.Implimentation
{
    public class ProductRepository<T> : IProductRepository<T> where T : Product
    {
        private ISession _session;
        public ProductRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<T> GetAllAvailablePaged(int page, int pageSize, Expression<Func<T, bool>> criteria)
        {
            return _session.QueryOver<T>().Where(criteria).Skip((page - 1) * pageSize).Take(pageSize).List();
        }

        public IEnumerable<T> GetByManufacturer(string manufacturer)
        {
            return _session.QueryOver<T>().Where(x => x.Manufacturer == manufacturer).List();
        }

        public IEnumerable<T> GetByModel(string model)
        {
            return _session.QueryOver<T>().Where(x => x.Model == model).List();
        }
    }
}