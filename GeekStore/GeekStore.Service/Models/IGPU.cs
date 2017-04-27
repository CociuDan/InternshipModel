namespace GeekStore.Service.Models
{
    public interface IGPU : IProduct
    {
        string Architecture { get; }
        string Description { get; }
        int InterfaceWidth { get; }
        string MemoryInterface { get; }
        int VRAM { get; }
    }
}
