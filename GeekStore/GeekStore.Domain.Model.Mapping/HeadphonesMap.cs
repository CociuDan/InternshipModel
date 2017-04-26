using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class HeadphonesMap : ClassMap<Headphones>
    {
        public HeadphonesMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Impendance).Not.Nullable();
            Map(x => x.MaxVolume).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}