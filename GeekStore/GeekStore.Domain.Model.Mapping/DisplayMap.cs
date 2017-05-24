using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class DisplayMap : ClassMap<Display>
    {
        public DisplayMap()
        {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.AspectRatio).Not.Nullable();
            Map(x => x.MaxRefreshRate).Not.Nullable();
            Map(x => x.Resolution).Not.Nullable();
            Map(x => x.Size).Not.Nullable();
        }
    }
}