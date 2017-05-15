namespace GeekStore.UI.Models
{
    public class CoolerViewModel : ProductViewModel
    {
        public virtual string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Socket}";
            }
        }
        public string Socket { get; set; }
    }
}