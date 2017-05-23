namespace GeekStore.Service.DTO
{
    public class GPUDTO : ProductDTO
    {
        public string Architecture { get; set; }
        public string Description { get; set; }
        public int InterfaceWidth { get; set; }
        public string MemoryInterface { get; set; }
        public int VRAM { get; set; }
    }
}