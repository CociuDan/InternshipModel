using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class DiskMap : ClassMap<Disk>
    {
        public DiskMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Capacity).Not.Nullable();
            Map(x => x.RPM).Nullable();
            Map(x => x.ReadSpeed).Nullable();
            Map(x => x.WriteSpeed).Nullable();
        }
    }
}
