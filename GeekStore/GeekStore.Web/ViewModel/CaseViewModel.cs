using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class CaseViewModel : ICase
    {
        public string Description { get; set; }
        public string FormFactor { get; set; }
    }
}