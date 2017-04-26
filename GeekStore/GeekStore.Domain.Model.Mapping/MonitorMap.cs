using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MonitorMap : ClassMap<Monitor>
    {
        public MonitorMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.AspectRatio).Not.Nullable();
            Map(x => x.MaxRefreshRate).Not.Nullable();
            Map(x => x.Resolution).Not.Nullable();
            Map(x => x.Size).Not.Nullable();
        }
    }
}