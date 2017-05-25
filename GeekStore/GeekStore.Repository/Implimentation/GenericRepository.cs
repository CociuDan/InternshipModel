using System.Collections.Generic;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain.Model;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Repository.Extensions;

namespace GeekStore.Repository.Implimentation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private ISession _session;

        public GenericRepository(ISession session)
        {
            _session = session;
        }

        public int Save(T entity)
        {
            _session.SaveOrUpdate(entity);
            return entity.ID;
        }

        public IEnumerable<T> GetAll()
        {
            return _session.QueryOver<T>().List();
        }

        public IEnumerable<T> GetAllPaged(PagedRequestDescription pagedDescription)
        {          
            return _session.QueryOver<T>().GetPagedResult(pagedDescription);
        }

        public T GetById(int id)
        {
            return _session.Get<T>(id);
        }

        public void Update(T entity)
        {
            _session.Update(entity);
        }

        public void Delete(int entityId)
        {
            var entity = GetById(entityId);
            _session.Delete(entity);
        }

        public int GetAllCount()
        {
            return _session.QueryOver<T>().RowCount();
        }
    }
}