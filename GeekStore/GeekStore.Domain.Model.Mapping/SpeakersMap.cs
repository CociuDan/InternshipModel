using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class SpeakersMap : ClassMap<Speakers>
    {
        public SpeakersMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Configuration);
            Map(x => x.MaxVolume);
        }
    }
}