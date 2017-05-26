namespace GeekStore.UI.Models.Common
{
    public class LaptopViewModel : ProductViewModel
    {
        public CPUViewModel CPU { get; set; }
        public DiskViewModel Disk { get; set; }
        public DisplayViewModel Display { get; set; }
        public GPUViewModel GPU { get; set; }
        public MotherboardViewModel Motherboard { get; set; }
        public PowerUnitViewModel PowerUnit { get; set; }
        public RAMViewModel RAM { get; set; }
    }
}