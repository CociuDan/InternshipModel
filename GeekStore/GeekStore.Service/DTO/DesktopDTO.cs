namespace GeekStore.Service.DTO
{
    public class DesktopDTO : EntityDTO
    {
        public CaseDTO Case { get; set; }
        public CoolerDTO Cooler { get; set; }
        public CPUDTO CPU { get; set; }
        public DiskDTO Disk { get; set; }
        public GPUDTO GPU { get; set; }
        public MotherboardDTO Motherboard { get; set; }
        public PowerUnitDTO PowerUnit { get; set; }
        public RAMDTO RAM { get; set; }
    }
}