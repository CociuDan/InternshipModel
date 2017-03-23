namespace GeekStore.Model.Infrastucture
{
    public interface IIDGenerator<T>
    {
        int NextID<T>();
    }
}