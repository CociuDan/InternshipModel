using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class DiskViewModel : ProductViewModel
    {
        public int Capacity { get; set; }
        public int? ReadSpeed { get; set; }
        public int? RPM { get; set; }
        public string Type { get; set; }
        public int? WriteSpeed { get; set; }
    }
}