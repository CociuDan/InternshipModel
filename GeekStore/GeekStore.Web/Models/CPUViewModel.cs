namespace GeekStore.UI.Models
{
    public class CPUViewModel : ProductViewModel
    {
        public decimal BaseFrequency { get; set; }
        public decimal BoostFrequency { get; set; }
        public int Cores { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Cores}/{Threads} @{BaseFrequency}-{BoostFrequency}Ghz {TDP}W {Socket}";
            }
        }
        public string Socket { get; set; }
        public int TDP { get; set; }
        public int Threads { get; set; }
    }
}