namespace GeekStore.Domain.Infrastucture
{
    public interface IIDGenerator<T>
    {
        int NextID<T>();
    }
}