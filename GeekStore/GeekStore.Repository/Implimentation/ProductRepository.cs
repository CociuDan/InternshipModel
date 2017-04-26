using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using NHibernate;
using System.Collections.Generic;

namespace GeekStore.Repository.Implimentation
{
    public class ProductRepository : IProductRepository
    {
        private ISession _session;
        public ProductRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<T> GetByManufacturer<T>(string manufacturer) where T : Product
        {
            return _session.QueryOver<T>().Where(x => x.Manufacturer == manufacturer).List();
        }

        public IEnumerable<T> GetByModel<T>(string model) where T : Product
        {
            return _session.QueryOver<T>().Where(x => x.Model == model).List();
        }
    }
}
