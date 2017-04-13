using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GeekStore.Domain.Model.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace GeekStore.Infrastucture
{
    public static class NHibernateProvider
    {
        private const string _connectionStringName = "GeekStoreConnectionString";

        private static ISessionFactory _sessionFactory;

        public static ISession GetSession()
        {
            if(_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c => c.FromConnectionStringWithKey(_connectionStringName)))
                .Mappings(x => x.FluentMappings.AddFromAssembly(typeof(CaseMap).Assembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

            return configuration.BuildSessionFactory();
        }
    }
}
