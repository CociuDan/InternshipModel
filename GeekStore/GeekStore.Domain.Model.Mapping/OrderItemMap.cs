using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Id(x => x.ID);
            Map(x => x.ProductType).Not.Nullable();
            Map(x => x.ProductFullDescription).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            Map(x => x.Quantity).Not.Nullable();
        }
    }
}