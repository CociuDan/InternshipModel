using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class CoolerViewModel : ProductViewModel, ICooler
    {
        public string Description { get; set; }
        public string Socket { get; set; }
    }
}