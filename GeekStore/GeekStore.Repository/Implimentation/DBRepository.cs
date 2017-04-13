using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using GeekStore.Domain.Model.Components;
using NHibernate;
using GeekStore.Repository.Interfaces;

namespace GeekStore.Repository.Implimentation
{
    public class DBRepository : IRepository
    {
        private ISession _session;
        public DBRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<CPU> GetCPUs()
        {
            return _session.QueryOver<CPU>().List();
        }
    }
}
