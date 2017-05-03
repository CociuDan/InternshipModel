using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class MonitorViewModel : ProductViewModel
    {
        public string AspectRatio { get; set; }
        public string Description { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}