using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class LaptopViewModel : ProductViewModel
    {
        public CPUDTO CPU { get; set; }
        public string Description { get; set; }
        public DiskDTO Disk { get; set; }
        public DisplayDTO Display { get; set; }
        public GPUDTO GPU { get; set; }
        public MotherboardDTO Motherboard { get; set; }
        public PowerUnitDTO PowerUnit { get; set; }
        public RAMDTO RAM { get; set; }
        public int RAMQuantity { get; set; }
    }
}