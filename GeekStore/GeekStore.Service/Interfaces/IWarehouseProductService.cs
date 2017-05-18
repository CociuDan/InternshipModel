using GeekStore.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces
{
    public interface IWarehouseProductService
    {
        WarehouseProductDTO GetByProductId(int productId);
    }
}
