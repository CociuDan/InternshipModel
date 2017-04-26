using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class KeyboardMap : ClassMap<Keyboard>
    {
        public KeyboardMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.BackLight).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}