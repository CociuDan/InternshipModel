using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class GPUViewModel : ProductViewModel, IGPU
    {
        public string Architecture { get; set; }
        public string Description { get; set; }
        public int InterfaceWidth { get; set; }
        public string MemoryInterface { get; set; }
        public int VRAM { get; set; }
    }
}