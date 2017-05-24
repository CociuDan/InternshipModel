namespace GeekStore.Service.DTO
{
    public class LaptopDTO : ProductDTO
    {
        public CPUDTO CPU { get; set; }
        public DisplayDTO Display { get; set; }
        public DiskDTO Disk { get; set; }
        public GPUDTO GPU { get; set; }
        public MotherboardDTO Motherboard { get; set; }
        public PowerUnitDTO PowerUnit { get; set; }
        public RAMDTO RAM { get; set; }
    }
}