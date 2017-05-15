using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class MonitorViewModel : ProductViewModel
    {
        public string AspectRatio { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Resolution} {AspectRatio} {MaxRefreshRate} {Size}";
            }
        }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}