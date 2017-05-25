namespace GeekStore.UI.Models.Common
{
    public class RAMViewModel : ProductViewModel
    {
        public int Capacity { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Generation} {Frequency}Mhz";
            }
        }
        public int Frequency { get; set; }
        public string Generation { get; set; }
    }
}