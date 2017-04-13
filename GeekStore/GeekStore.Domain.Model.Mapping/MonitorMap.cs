using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MonitorMap : ClassMap<Monitor>
    {
        public MonitorMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.AspectRatio);
            Map(x => x.MaxRefreshRate);
            Map(x => x.Resolution);
            Map(x => x.Size);
        }
    }
}