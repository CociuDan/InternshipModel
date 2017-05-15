using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public class PowerUnitViewModel : ProductViewModel
    {
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Output}";
            }
        }
        public int Output { get; set; }
    }
}