using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class MouseMap : ClassMap<Mouse>
    {
        public MouseMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.DPI).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}