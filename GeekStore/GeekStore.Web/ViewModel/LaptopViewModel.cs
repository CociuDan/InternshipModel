using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class LaptopViewModel : ProductViewModel, ILaptop
    {
        public ICPU CPU { get; set; }
        public string Description { get; set; }
        public IDisk Disk { get; set; }
        public IDisplay Display { get; set; }
        public IGPU GPU { get; set; }
        public IMotherboard Motherboard { get; set; }
        public IPowerUnit PowerUnit { get; set; }
        public IRAM RAM { get; set; }
        public int RAMQuantity { get; set; }
    }
}