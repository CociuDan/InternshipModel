using GeekStore.Service.Models;

namespace GeekStore.UI.ViewModel
{
    public abstract class EntityViewModel : IEntity
    {
        public int ID { get; set; }
    }
}