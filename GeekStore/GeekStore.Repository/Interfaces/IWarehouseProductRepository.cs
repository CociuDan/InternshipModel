using GeekStore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Repository.Interfaces
{
    public interface IWarehouseProductRepository
    {
        WarehouseProduct GetByProductId(int productId);
    }
}
