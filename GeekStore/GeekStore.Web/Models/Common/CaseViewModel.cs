namespace GeekStore.UI.Models.Common
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