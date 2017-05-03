using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class MouseViewModel : ProductViewModel
    {
        public string Description { get; set; }
        public int DPI { get; set; }
        public string Type { get; set; }
    }
}