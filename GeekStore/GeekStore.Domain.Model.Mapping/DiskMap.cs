using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class DiskMap : SubclassMap<Disk>
    {
        public DiskMap()
        {
            KeyColumn("ID");
            Map(x => x.Capacity).Not.Nullable();
            Map(x => x.RPM).Nullable();
            Map(x => x.ReadSpeed).Nullable();
            Map(x => x.WriteSpeed).Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}
