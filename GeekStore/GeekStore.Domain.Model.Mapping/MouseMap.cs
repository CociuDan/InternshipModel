using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MouseMap : SubclassMap<Mouse>
    {
        public MouseMap()
        {
            KeyColumn("ID");
            Map(x => x.DPI).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}