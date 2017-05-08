using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class MotherboardMap : SubclassMap<Motherboard>
    {
        public MotherboardMap()
        {
            KeyColumn("ID");
            Map(x => x.Chipset).Not.Nullable();
            Map(x => x.PCIESlots).Not.Nullable();
            Map(x => x.RAMSlots).Not.Nullable();
            Map(x => x.Socket).Not.Nullable();
        }
    }
}