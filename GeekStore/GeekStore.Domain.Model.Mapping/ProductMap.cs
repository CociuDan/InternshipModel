using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.ID).GeneratedBy.HiLo("1");
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Price);
            Map(x => x.AvailableQuantity);
            UseUnionSubclassForInheritanceMapping();
        }
    }
}
