namespace GeekStore.Service.Models
{
    public interface ISpeakers : IProduct
    {
        string Description { get; }
        string Configuration { get; }
        int MaxVolume { get; }
    }
}
