using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CoolerMap : ClassMap<Cooler>
    {
        public CoolerMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Socket);
        }
    }
}