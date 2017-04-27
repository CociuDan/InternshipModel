namespace GeekStore.Service.Models
{
    public interface IRAM : IProduct
    {
        string Description { get; }
        int Capacity { get; }
        int Frequency { get; }
        string Generation { get; }
    }
}
