namespace GeekStore.UI.Models.Common
{
    public class DiskViewModel : ProductViewModel
    {
        public int Capacity { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Capacity}GB {Type} {RPM} {ReadSpeed} {WriteSpeed}";
            }
        }
        public int? ReadSpeed { get; set; }
        public int? RPM { get; set; }
        public string Type { get; set; }
        public int? WriteSpeed { get; set; }
    }
}