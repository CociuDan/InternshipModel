using GeekStore.Model.Components.CPUs;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components.GPUs;
using GeekStore.Model.Components.Motherboards;
using GeekStore.Model.Components.PowerUnits;
using GeekStore.Model.Components.RAMs;

namespace GeekStore.Model.PCs
{
    public interface IComputer
    {
        CPU CPU { get; }
        Disk Disk { get; }
        GPU GPU { get; }
        Motherboard Motherboard { get; }
        PowerUnit PowerUnit { get; }
        RAM RAM { get; }
    }
}