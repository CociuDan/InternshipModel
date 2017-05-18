using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class CaseMap : SubclassMap<Case>
    {
        public CaseMap()
        {
            KeyColumn("ID");            
            Map(x => x.FormFactor).Not.Nullable();
        }
    }
}