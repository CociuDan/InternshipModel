namespace GeekStore.Service.DTO
{
    public class DisplayDTO : EntityDTO
    {
        public string AspectRatio { get; }
        public int MaxRefreshRate { get; }
        public string Resolution { get; }
        public decimal Size { get; }
    }
}