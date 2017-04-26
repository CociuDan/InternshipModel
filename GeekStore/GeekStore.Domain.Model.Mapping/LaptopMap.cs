using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class LaptopMap : ClassMap<Laptop>
    {
        public LaptopMap()
        {
            Id(x => x.ID);
            References(x => x.CPU).LazyLoad();
            References(x => x.Disk).LazyLoad();
            References(x => x.Display).LazyLoad();
            References(x => x.GPU).LazyLoad();
            References(x => x.Motherboard).LazyLoad();
            References(x => x.PowerUnit).LazyLoad();
            References(x => x.RAM).LazyLoad();
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
        }
    }
}