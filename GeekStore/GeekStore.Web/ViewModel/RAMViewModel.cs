using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class RAMViewModel : ProductViewModel, IRAM
    {
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int Frequency { get; set; }
        public string Generation { get; set; }
    }
}