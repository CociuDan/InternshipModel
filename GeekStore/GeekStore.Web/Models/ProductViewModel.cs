using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public abstract class ProductViewModel : EntityViewModel
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}