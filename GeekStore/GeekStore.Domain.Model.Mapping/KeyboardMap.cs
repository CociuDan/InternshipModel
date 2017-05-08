using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class KeyboardMap : SubclassMap<Keyboard>
    {
        public KeyboardMap()
        {
            KeyColumn("ID");
            Map(x => x.BackLight).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}