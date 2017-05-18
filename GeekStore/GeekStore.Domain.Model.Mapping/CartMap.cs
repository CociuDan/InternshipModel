using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Id(x => x.ID);
            References(x => x.User).Not.Nullable();
            HasMany(x => x.Product).KeyColumn("GarageId");
            Map(x => x.Quantity).Not.Nullable();
        }
    }
}
