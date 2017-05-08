using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class WarehouseProductMap : ClassMap<WarehouseProduct>
    {
        public WarehouseProductMap()
        {
            Id(x => x.ID);
            Map(x => x.ItemID);
            Map(x => x.ItemType);
            Map(x => x.Price);
            Map(x => x.Quantity);
        }
    }
}
