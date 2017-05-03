namespace GeekStore.Service.DTO
{
    public class SpeakersDTO : ProductDTO
    {
        public string Description { get; }
        public string Configuration { get; }
        public int MaxVolume { get; }
    }
}