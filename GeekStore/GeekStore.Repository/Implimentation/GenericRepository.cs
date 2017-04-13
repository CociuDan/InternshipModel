using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using GeekStore.Domain.Model.Components;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;

namespace GeekStore.Repository.Implimentation
{
    public class GenericRepository : IRepository
    {
        private ISession _session;
        public GenericRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<T> GetAll<T>() where T : Item
        {
            return _session.QueryOver<T>().List();
        }

        public Item GetById<T>(int id) where T : Item
        {
            return _session.Get<T>(id);
        }
    }
}
