using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class CartMap : ClassMap<Cart>
    {
        public CartMap()
        {
            Id(x => x.ID).GeneratedBy.Identity();
            References(x => x.Product).Not.Nullable();
            References(x => x.User).Not.Nullable();
            Map(x => x.Quantity);
        }
    }
}