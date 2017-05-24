namespace GeekStore.Service.DTO
{
    public class DiskDTO : ProductDTO
    {
        public int Capacity { get; set; }
        public int? RPM { get; set; }
        public int? ReadSpeed { get; set; }
        public string Type { get; set; }
        public int? WriteSpeed { get; set; }
    }
}