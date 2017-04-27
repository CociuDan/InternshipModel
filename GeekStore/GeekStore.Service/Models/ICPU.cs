namespace GeekStore.Service.Models
{
    public interface ICPU : IProduct
    {
        decimal BaseFrequency { get; }
        decimal BoostFrequency { get; }
        int Cores { get; }
        string Description { get; }
        string Socket { get; }
        int TDP { get; }
        int Threads { get; }
    }
}
