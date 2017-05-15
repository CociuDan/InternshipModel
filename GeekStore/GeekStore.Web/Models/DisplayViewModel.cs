namespace GeekStore.UI.Models
{
    public class DisplayViewModel : ProductViewModel
    {
        public string AspectRatio { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Resolution} {AspectRatio} {Size} {MaxRefreshRate}";
            }
        }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}