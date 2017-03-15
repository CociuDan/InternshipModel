namespace GeekStore.Model
{
    public interface IItem
    {
        string Description { get; }
        string Manufacturer { get; }
        string Model { get; }
    }
}
