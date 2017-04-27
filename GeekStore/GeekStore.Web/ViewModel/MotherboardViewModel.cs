using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class MotherboardViewModel : ProductViewModel, IMotherboard
    {
        public string Chipset { get; set; }
        public string Description { get; set; }
        public int PCIESlots { get; set; }
        public int RAMSlots { get; set; }
        public string Socket { get; set; }
    }
}