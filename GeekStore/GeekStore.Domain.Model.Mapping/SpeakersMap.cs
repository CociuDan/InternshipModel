using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class SpeakersMap : ClassMap<Speakers>
    {
        public SpeakersMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Configuration).Not.Nullable();
            Map(x => x.MaxVolume).Not.Nullable();
        }
    }
}