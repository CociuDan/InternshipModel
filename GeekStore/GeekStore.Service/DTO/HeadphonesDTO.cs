namespace GeekStore.Service.DTO
{
    public class HeadphonesDTO : ProductDTO
    {
        public string Description { get; set; }
        public int Impendance { get; set; }
        public int MaxVolume { get; set; }
        public string Type { get; set; }
    }
}