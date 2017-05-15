namespace GeekStore.UI.Models
{
    public class HeadphonesViewModel : ProductViewModel
    {
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Type} {Impendance}Ω {MaxVolume}Db";
            }
        }
        public int Impendance { get; set; }
        public int MaxVolume { get; set; }
        public string Type { get; set; }
    }
}