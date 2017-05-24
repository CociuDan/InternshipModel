namespace GeekStore.Service.DTO
{
    public class DisplayDTO : EntityDTO
    {
        public string AspectRatio { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}