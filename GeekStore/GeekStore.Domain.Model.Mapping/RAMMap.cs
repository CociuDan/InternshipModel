using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class RAMMap : SubclassMap<RAM>
    {
        public RAMMap()
        {
            KeyColumn("ID");
            Map(x => x.Capacity).Not.Nullable();
            Map(x => x.Frequency).Not.Nullable();
            Map(x => x.Generation).Not.Nullable();
        }
    }
}