namespace GeekStore.UI.Models.Common
{
    public class PowerUnitViewModel : ProductViewModel
    {
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Output}";
            }
        }
        public int Output { get; set; }
    }
}