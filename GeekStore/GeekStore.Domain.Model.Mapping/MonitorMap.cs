using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MonitorMap : SubclassMap<Monitor>
    {
        public MonitorMap()
        {
            KeyColumn("ID");
            References(x => x.Display);
        }
    }
}