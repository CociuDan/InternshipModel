using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class PowerUnitMap : SubclassMap<PowerUnit>
    {
        public PowerUnitMap()
        {
            KeyColumn("ID");
            Map(x => x.Output).Not.Nullable();
        }
    }
}