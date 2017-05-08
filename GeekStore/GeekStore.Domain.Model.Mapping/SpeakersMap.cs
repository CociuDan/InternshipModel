using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Domain.Model.Mapping
{
    public class SpeakersMap : SubclassMap<Speakers>
    {
        public SpeakersMap()
        {
            KeyColumn("ID");
            Map(x => x.Configuration).Not.Nullable();
            Map(x => x.MaxVolume).Not.Nullable();
        }
    }
}