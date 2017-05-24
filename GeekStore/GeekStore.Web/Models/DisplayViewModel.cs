namespace GeekStore.UI.Models
{
    public class DisplayViewModel : EntityViewModel
    {
        public string AspectRatio { get; set; }
        public string Description
        {
            get
            {
                return $"{Resolution} {AspectRatio} {Size} {MaxRefreshRate}";
            }
        }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}