namespace GeekStore.Service.Models
{
    public interface IDisplay : IEntity
    {
        string AspectRatio { get; }
        int MaxRefreshRate { get; }
        string Resolution { get; }
        decimal Size { get; }
    }
}
