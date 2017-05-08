using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class HeadphonesMap : SubclassMap<Headphones>
    {
        public HeadphonesMap()
        {
            KeyColumn("ID");
            Map(x => x.Impendance).Not.Nullable();
            Map(x => x.MaxVolume).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
        }
    }
}