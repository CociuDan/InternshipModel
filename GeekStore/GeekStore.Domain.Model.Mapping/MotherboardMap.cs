using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class MotherboardMap : ClassMap<Motherboard>
    {
        public MotherboardMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Chipset);
            Map(x => x.PCIESlots);
            Map(x => x.RAMSlots);
            Map(x => x.Socket);
        }
    }
}