namespace GeekStore.UI.Models.Common
{
    public class MotherboardViewModel : ProductViewModel
    {
        public string Chipset { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Socket} {Chipset} {PCIESlots} PCI-E {RAMSlots} DIMMS";
            }
        }
        public int PCIESlots { get; set; }
        public int RAMSlots { get; set; }
        public string Socket { get; set; }
    }
}