using GeekStore.Repository.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekStore.Domain.Model;
using NHibernate.Transform;

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
