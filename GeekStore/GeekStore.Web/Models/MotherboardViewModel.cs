using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class MotherboardViewModel : ProductViewModel
    {
        public string Chipset { get; set; }
        public string Description { get; set; }
        public int PCIESlots { get; set; }
        public int RAMSlots { get; set; }
        public string Socket { get; set; }
    }
}