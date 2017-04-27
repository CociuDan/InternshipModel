using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class MonitorViewModel : ProductViewModel, IMonitor
    {
        public string AspectRatio { get; set; }
        public string Description { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}