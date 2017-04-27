using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public abstract class ProductViewModel : EntityViewModel, IProduct
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}