namespace GeekStore.Service.DTO
{
    public class GPUDTO : ProductDTO
    {
        public string Architecture { get; }
        public string Description { get; }
        public int InterfaceWidth { get; }
        public string MemoryInterface { get; }
        public int VRAM { get; }
    }
}