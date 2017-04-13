using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CPUMap : ClassMap<CPU>
    {
        public CPUMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.BaseFrequency);
            Map(x => x.BoostFrequency);
            Map(x => x.Cores);
            Map(x => x.Socket);
            Map(x => x.TDP);
            Map(x => x.Threads);
        }
    }
}