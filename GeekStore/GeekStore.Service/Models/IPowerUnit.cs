namespace GeekStore.Service.Models
{
    public interface IPowerUnit : IProduct
    {
        string Description { get; }
        int Output { get; }
    }
}
