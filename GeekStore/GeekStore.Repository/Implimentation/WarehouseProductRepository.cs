using GeekStore.Repository.Interfaces;
using NHibernate;
using GeekStore.Domain.Model;

namespace GeekStore.Repository.Implimentation
{
    public class WarehouseProductRepository : IWarehouseProductRepository
    {
        private ISession _session;

        public WarehouseProductRepository(ISession session)
        {
            _session = session;
        }

        public WarehouseProduct GetByProductId(int productId)
        {
            return _session.QueryOver<WarehouseProduct>().Where(x => x.Product.ID == productId).SingleOrDefault();
        }
    }
}