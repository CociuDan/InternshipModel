using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MonitorMap : SubclassMap<Monitor>
    {
        public MonitorMap()
        {
            KeyColumn("ID");
            Map(x => x.AspectRatio).Not.Nullable();
            Map(x => x.MaxRefreshRate).Not.Nullable();
            Map(x => x.Resolution).Not.Nullable();
            Map(x => x.Size).Not.Nullable();
        }
    }
}