using FluentNHibernate.Mapping;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Mapping
{
    public class GPUMap : ClassMap<GPU>
    {
        public GPUMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
            Map(x => x.Architecture);
            Map(x => x.InterfaceWidth);
            Map(x => x.MemoryInterface);
            Map(x => x.VRAM);
        }
    }
}