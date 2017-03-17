using GeekStore.Model.Components;
using GeekStore.Model.Components.Disks;

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