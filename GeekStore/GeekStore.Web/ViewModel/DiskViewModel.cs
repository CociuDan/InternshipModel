using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class DiskViewModel : ProductViewModel, IDisk
    {
        public int Capacity { get; set; }
        public int? ReadSpeed { get; set; }
        public int? RPM { get; set; }
        public string Type { get; set; }
        public int? WriteSpeed { get; set; }
    }
}