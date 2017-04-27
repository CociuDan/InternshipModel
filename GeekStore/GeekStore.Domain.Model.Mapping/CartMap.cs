using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Id(x => x.ID);
            References(x => x.User).Not.Nullable();
            References(x => x.Product).Not.Nullable();
            Map(x => x.Quantity).Not.Nullable();
        }
    }
}
