using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components.Disks;

namespace GeekStore.Domain.Model.Mapping
{
    public class HDDMap : ClassMap<HDD>
    {
        public HDDMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Capacity);
            Map(x => x.RPM);
        }
    }
}