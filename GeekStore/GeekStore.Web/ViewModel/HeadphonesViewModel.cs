using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class HeadphonesViewModel : ProductViewModel, IHeadphones
    {
        public string Description { get; set; }
        public int Impendance { get; set; }
        public int MaxVolume { get; set; }
        public string Type { get; set; }
    }
}