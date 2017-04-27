using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class DisplayViewModel : EntityViewModel, IDisplay
    {
        public string AspectRatio { get; set; }
        public int MaxRefreshRate { get; set; }
        public string Resolution { get; set; }
        public decimal Size { get; set; }
    }
}