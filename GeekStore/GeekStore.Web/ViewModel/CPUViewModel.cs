using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class CPUViewModel : ProductViewModel, ICPU
    {
        public decimal BaseFrequency { get; set; }
        public decimal BoostFrequency { get; set; }
        public int Cores { get; set; }
        public string Description { get; set; }
        public string Socket { get; set; }
        public int TDP { get; set; }
        public int Threads { get; set; }
    }
}