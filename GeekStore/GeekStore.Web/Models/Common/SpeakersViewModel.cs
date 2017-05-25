namespace GeekStore.UI.Models.Common
{
    public class SpeakersViewModel : ProductViewModel
    {
        public string Configuration { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Configuration} {MaxVolume}Db";
            }
        }
        public int MaxVolume { get; set; }
    }
}