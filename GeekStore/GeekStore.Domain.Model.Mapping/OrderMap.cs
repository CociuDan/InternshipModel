using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.ID);
            Map(x => x.OrderDate);
            HasMany(x => x.OrderItems)
                .KeyColumn("Order_ID")
                .Cascade.AllDeleteOrphan()
                .LazyLoad();
            Map(x => x.TotalPrice);
            References(x => x.User);
        }
    }
}