namespace GeekStore.Service.Models
{
    public interface IDisk : IProduct
    {
        int Capacity { get; }
        int? RPM { get; }
        int? ReadSpeed { get; }
        string Type { get; }
        int? WriteSpeed { get; }
    }
}
