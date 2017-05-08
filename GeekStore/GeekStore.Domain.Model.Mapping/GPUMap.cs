using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class GPUMap : SubclassMap<GPU>
    {
        public GPUMap()
        {
            KeyColumn("ID");
            Map(x => x.Architecture).Not.Nullable();
            Map(x => x.InterfaceWidth).Not.Nullable();
            Map(x => x.MemoryInterface).Not.Nullable();
            Map(x => x.VRAM).Not.Nullable();
        }
    }
}