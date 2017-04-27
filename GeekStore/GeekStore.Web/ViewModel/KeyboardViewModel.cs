using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public class KeyboardViewModel : ProductViewModel, IKeyboard
    {
        public bool BackLight { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}