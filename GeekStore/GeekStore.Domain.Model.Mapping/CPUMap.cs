using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CPUMap : ClassMap<CPU>
    {
        public CPUMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.BaseFrequency).Not.Nullable();
            Map(x => x.BoostFrequency).Not.Nullable();
            Map(x => x.Cores).Not.Nullable();
            Map(x => x.Socket).Not.Nullable();
            Map(x => x.TDP).Not.Nullable();
            Map(x => x.Threads).Not.Nullable();
        }
    }
}