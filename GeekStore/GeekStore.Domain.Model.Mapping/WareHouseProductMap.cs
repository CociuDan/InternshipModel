using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class WareHouseProductMap : ClassMap<WareHouseProduct>
    {
        public WareHouseProductMap()
        {
            Id(x => x.ID);
            Map(x => x.ItemID);
            Map(x => x.ItemType);
            Map(x => x.Price);
            Map(x => x.Quantity);
        }
    }
}
