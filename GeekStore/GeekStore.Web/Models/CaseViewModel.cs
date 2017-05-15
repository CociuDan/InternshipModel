namespace GeekStore.UI.Models
{
    public class CaseViewModel : ProductViewModel
    {
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {FormFactor}";
            }
        }
        public string FormFactor { get; set; }
    }
}