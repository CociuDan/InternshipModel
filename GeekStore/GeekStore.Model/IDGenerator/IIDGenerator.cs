namespace GeekStore.Domain.Model.IDGenerator
{
    public interface IIDGenerator<T>
    {
        int NextID { get; }
    }
}