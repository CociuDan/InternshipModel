namespace GeekStore.UI.Models
{
    public class DisplayViewModel : ProductViewModel
    {
        public string AspectRatio { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}