namespace GeekStore.Service.Models
{
    public interface IMonitor : IProduct, IDisplay
    {
        string Description { get; }
    }
}
