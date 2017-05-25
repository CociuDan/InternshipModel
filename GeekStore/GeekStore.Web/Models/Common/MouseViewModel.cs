namespace GeekStore.UI.Models.Common
{
    public class MouseViewModel : ProductViewModel
    {
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Type} {DPI}DPI";
            }
        }
        public int DPI { get; set; }
        public string Type { get; set; }
    }
}