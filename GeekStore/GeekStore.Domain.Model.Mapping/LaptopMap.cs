using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class LaptopMap : SubclassMap<Laptop>
    {
        public LaptopMap()
        {
            KeyColumn("ID");
            References(x => x.CPU).LazyLoad();
            References(x => x.Disk).LazyLoad();
            References(x => x.Display).LazyLoad();
            References(x => x.GPU).LazyLoad();
            References(x => x.Motherboard).LazyLoad();
            References(x => x.PowerUnit).LazyLoad();
            References(x => x.RAM).LazyLoad();
            Map(x => x.RAMQuantity).Not.Nullable();
        }
    }
}