using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class SpeakersViewModel : ProductViewModel, ISpeakers
    {
        public string Configuration { get; set; }
        public string Description { get; set; }
        public int MaxVolume { get; set; }
    }
}