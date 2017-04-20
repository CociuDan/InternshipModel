using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class LaptopMap : ClassMap<Laptop>
    {
        public LaptopMap()
        {
            Id(x => x.ID);
            References(x => x.CPU);
            References(x => x.Disk);
            References(x => x.Display);
            References(x => x.GPU);
            References(x => x.Motherboard);
            References(x => x.PowerUnit);
            References(x => x.RAM);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
        }
    }
}