namespace GeekStore.UI.Models
{
    public class DesktopViewModel : EntityViewModel
    {
        public CaseViewModel Case { get; set; }
        public CoolerViewModel Cooler { get; set; }
        public CPUViewModel CPU { get; set; }
        public DiskViewModel Disk { get; set; }
        public GPUViewModel GPU { get; set; }
        public MotherboardViewModel Motherboard { get; set; }
        public PowerUnitViewModel PowerUnit { get; set; }
        public RAMViewModel RAM { get; set; }
    }
}