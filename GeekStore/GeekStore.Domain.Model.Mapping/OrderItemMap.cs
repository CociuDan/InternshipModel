using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Id(x => x.ID);
            References(x => x.Order).Not.Nullable();
            References(x => x.Product).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            Map(x => x.Quantity).Not.Nullable();
        }
    }
}