using GeekStore.Domain.Components;
using GeekStore.Domain.Components.Disks;

namespace GeekStore.Domain.PCs
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