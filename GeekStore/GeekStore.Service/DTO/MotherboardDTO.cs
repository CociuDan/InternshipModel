namespace GeekStore.Service.DTO
{
    public class MotherboardDTO : ProductDTO
    {
        public string Chipset { get; set; }
        public int PCIESlots { get; set; }
        public int RAMSlots { get; set; }
        public string Socket { get; set; }
    }
}