using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class DisplayMap : ClassMap<Display>
    {
        public DisplayMap()
        {
            Id(x => x.ID);
            Map(x => x.AspectRatio);
            Map(x => x.MaxRefreshRate);
            Map(x => x.Resolution);
            Map(x => x.Size);
        }
    }
}