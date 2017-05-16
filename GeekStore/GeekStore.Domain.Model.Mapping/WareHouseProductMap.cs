using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class WarehouseProductMap : ClassMap<WarehouseProduct>
    {
        public WarehouseProductMap()
        {
            Id(x => x.ID);
            References(x => x.Product);
            Map(x => x.Price);
            Map(x => x.Quantity);
        }
    }
}
