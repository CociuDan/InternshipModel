namespace GeekStore.UI.Models.Common
{
    public class MotherboardViewModel : ProductViewModel
    {
        public string Chipset { get; set; }
        public int PCIESlots { get; set; }
        public int RAMSlots { get; set; }
        public string Socket { get; set; }
    }
}