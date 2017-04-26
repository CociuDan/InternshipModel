using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CoolerMap : ClassMap<Cooler>
    {
        public CoolerMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Socket).Not.Nullable();
        }
    }
}