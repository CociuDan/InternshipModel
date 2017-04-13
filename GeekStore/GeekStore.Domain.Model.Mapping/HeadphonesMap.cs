using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class HeadphonesMap : ClassMap<Headphones>
    {
        public HeadphonesMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Impendance);
            Map(x => x.MaxVolume);
            Map(x => x.Type);
        }
    }
}