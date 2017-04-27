namespace GeekStore.Service.Models
{
    public interface IKeyboard : IProduct
    {
        string Description { get; }
        bool BackLight { get; }
        string Type { get; }
    }
}
