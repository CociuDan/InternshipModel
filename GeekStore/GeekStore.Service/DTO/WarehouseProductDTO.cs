using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.DTO
{
    public class WarehouseProductDTO : EntityDTO
    {
        public ProductDTO Product { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }
    }
}