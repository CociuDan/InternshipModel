namespace GeekStore.Service.DTO
{
    public class MotherboardDTO : ProductDTO
    {
        public string Chipset { get; }
        public string Description { get; }
        public int PCIESlots { get; }
        public int RAMSlots { get; }
        public string Socket { get; }
    }
}