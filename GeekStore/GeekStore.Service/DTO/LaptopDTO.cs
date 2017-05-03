namespace GeekStore.Service.DTO
{
    public class LaptopDTO : ProductDTO
    {
        public CPUDTO CPU { get; }
        public string Description { get; }
        public DisplayDTO Display { get; }
        public DiskDTO Disk { get; }
        public GPUDTO GPU { get; }
        public MotherboardDTO Motherboard { get; }
        public PowerUnitDTO PowerUnit { get; }
        public RAMDTO RAM { get; }
        public int RAMQuantity { get; }
    }
}