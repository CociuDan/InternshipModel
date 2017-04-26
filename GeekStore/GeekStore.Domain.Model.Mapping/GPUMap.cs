using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class GPUMap : ClassMap<GPU>
    {
        public GPUMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            Map(x => x.Architecture).Not.Nullable();
            Map(x => x.InterfaceWidth).Not.Nullable();
            Map(x => x.MemoryInterface).Not.Nullable();
            Map(x => x.VRAM).Not.Nullable();
        }
    }
}