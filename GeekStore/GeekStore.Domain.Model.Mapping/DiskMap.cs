using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class DiskMap : ClassMap<Disk>
    {
        public DiskMap()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Capacity);
            Map(x => x.RPM);
            Map(x => x.ReadSpeed);
            Map(x => x.WriteSpeed);
        }
    }
}
