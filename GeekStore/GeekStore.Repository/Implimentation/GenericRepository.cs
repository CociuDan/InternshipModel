using System.Collections.Generic;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using NHibernate.Criterion;

namespace GeekStore.Repository.Implimentation
{
    public class GenericRepository : IRepository
    {
        private ISession _session;
        private ITransaction _transaction;
        public GenericRepository(ISession session)
        {
            _session = session;
            _transaction = _session.BeginTransaction();
        }

        public void Save<T>(T item) where T : Item
        {
            _session.SaveOrUpdate(item);
        }

        public IEnumerable<T> GetAll<T>() where T : Item
        {
            return _session.QueryOver<T>().List();
        }

        public Item GetById<T>(int id) where T : Item
        {
            return _session.Get<T>(id);
        }

        public void Update<T>(T item)
        {
            _session.Update(item);
        }

        public void Delete<T>(T item)
        {
            _session.Delete(item);
            _transaction.Commit();
        }

        public IEnumerable<T> GetByManufacturer<T>(string manufacturer) where T : Product
        {
            return _session.QueryOver<T>().Where(x => x.Manufacturer == manufacturer).List();
        }

        public IEnumerable<T> GetByModel<T>(string model) where T : Product
        {
            return _session.QueryOver<T>().Where(x => x.Model == model).List();
        }

        public IEnumerable<CPU> GetTOPCPUs()
        {
            return _session.QueryOver<CPU>().Where(x => x.Model.Contains("i7") || x.Model.Contains("R7")).List();
        }

    //    public IEnumerable<Laptop> GetLaptops()
    //    {
    //        Laptop laptopAlias = null;
    //        CPU cpuAlias = null;
    //        return _session.QueryOver(() => laptopAlias)
    //                       .JoinAlias(() => laptopAlias.CPU, () => cpuAlias)
    //                       .Where(Restrictions.On(() => cpuAlias.Model).IsLike("%6950X%"))
    //                       .Select(x=>x.ID).List();
    //    }
    }
}
