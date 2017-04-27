namespace GeekStore.Service.Models
{
    public interface IMouse : IProduct
    {
        string Description { get; }
        int DPI { get; }
        string Type { get; }
    }
}
