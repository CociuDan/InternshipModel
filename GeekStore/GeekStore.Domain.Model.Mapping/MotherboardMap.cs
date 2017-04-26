using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class MotherboardMap : ClassMap<Motherboard>
    {
        public MotherboardMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Chipset).Not.Nullable();
            Map(x => x.PCIESlots).Not.Nullable();
            Map(x => x.RAMSlots).Not.Nullable();
            Map(x => x.Socket).Not.Nullable();
        }
    }
}