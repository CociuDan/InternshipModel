namespace GeekStore.UI.Models.Common
{
    public class DisplayViewModel : EntityViewModel
    {
        public string AspectRatio { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}