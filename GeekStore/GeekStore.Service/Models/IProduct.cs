namespace GeekStore.Service.Models
{
    public interface IProduct : IEntity
    {
        string Manufacturer { get; }
        string Model { get; }
    }
}
