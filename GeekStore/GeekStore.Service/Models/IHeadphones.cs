namespace GeekStore.Service.Models
{
    public interface IHeadphones : IProduct
    {
        string Description { get; }
        int Impendance { get; }
        int MaxVolume { get; }
        string Type { get; }
    }
}
