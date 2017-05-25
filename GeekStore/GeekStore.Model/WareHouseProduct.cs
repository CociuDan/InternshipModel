using System;

namespace GeekStore.Domain.Model
{
    public class WarehouseProduct : Entity
    {
        public WarehouseProduct() { }

        public virtual Product Product { get; protected set; }

        public virtual decimal? Price { get; protected set; }

        public virtual int? Quantity { get; protected set; }
    }
}