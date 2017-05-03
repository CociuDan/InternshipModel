namespace GeekStore.Service.DTO
{
    public class RAMDTO : ProductDTO
    {
        public string Description { get; }
        public int Capacity { get; }
        public int Frequency { get; }
        public string Generation { get; }
    }
}