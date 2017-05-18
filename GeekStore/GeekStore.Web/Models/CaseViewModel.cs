namespace GeekStore.UI.Models
{
    public class CaseViewModel : ProductViewModel
    {
        public CaseViewModel()
        {

        }
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