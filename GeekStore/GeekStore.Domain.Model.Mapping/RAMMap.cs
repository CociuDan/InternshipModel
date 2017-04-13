using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class RAMMap : ClassMap<RAM>
    {
        public RAMMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Capacity);
            Map(x => x.Frequency);
            Map(x => x.Generation);
        }
    }
}