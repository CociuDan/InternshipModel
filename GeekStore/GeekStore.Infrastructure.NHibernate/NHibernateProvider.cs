using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GeekStore.Domain.Model.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace GeekStore.Infrastructure.NHibernate
{
    public class NHibernateProvider
    {
        private string _connectionString;
        private ISessionFactory _sessionFactory;

        public NHibernateProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    _sessionFactory = CreateSessionFactory();
                return _sessionFactory;
            }
        }

        private ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c => c.FromConnectionStringWithKey(_connectionString)))
                .Mappings(x => x.FluentMappings.AddFromAssembly(typeof(CaseMap).Assembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

            return configuration.BuildSessionFactory();
        }
    }
}
