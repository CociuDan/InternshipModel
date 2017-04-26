using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class RAMMap : ClassMap<RAM>
    {
        public RAMMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Capacity).Not.Nullable();
            Map(x => x.Frequency).Not.Nullable();
            Map(x => x.Generation).Not.Nullable();
        }
    }
}