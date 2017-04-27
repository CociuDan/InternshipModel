using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class PowerUnitViewModel : ProductViewModel, IPowerUnit
    {
        public string Description { get; set; }
        public int Output { get; set; }
    }
}