using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class MouseViewModel : ProductViewModel, IMouse
    {
        public string Description { get; set; }
        public int DPI { get; set; }
        public string Type { get; set; }
    }
}