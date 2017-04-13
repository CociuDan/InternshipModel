using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class KeyboardMap : ClassMap<Keyboard>
    {
        public KeyboardMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.BackLight);
            Map(x => x.Type);
        }
    }
}