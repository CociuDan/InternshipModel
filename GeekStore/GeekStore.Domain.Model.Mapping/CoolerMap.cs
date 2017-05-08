using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CoolerMap : SubclassMap<Cooler>
    {
        public CoolerMap()
        {
            KeyColumn("ID");
            Map(x => x.Socket).Not.Nullable();
        }
    }
}