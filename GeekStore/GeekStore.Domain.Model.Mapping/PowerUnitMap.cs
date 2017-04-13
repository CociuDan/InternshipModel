using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class PowerUnitMap : ClassMap<PowerUnit>
    {
        public PowerUnitMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Output);
        }
    }
}