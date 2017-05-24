namespace GeekStore.Service.DTO
{
    public class RAMDTO : ProductDTO
    {
        public int Capacity { get; set; }
        public int Frequency { get; set; }
        public string Generation { get; set; }
    }
}