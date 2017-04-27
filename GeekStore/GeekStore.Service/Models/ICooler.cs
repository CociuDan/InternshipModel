namespace GeekStore.Service.Models
{
    public interface ICooler : IProduct
    {
        string Description { get; }
        string Socket { get; }
    }
}
