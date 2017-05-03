using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class RAMViewModel : ProductViewModel
    {
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int Frequency { get; set; }
        public string Generation { get; set; }
    }
}