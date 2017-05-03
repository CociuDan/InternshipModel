namespace GeekStore.Service.DTO
{
    public class DiskDTO : ProductDTO
    {
        public int Capacity { get; }
        public int? RPM { get; }
        public int? ReadSpeed { get; }
        public string Type { get; }
        public int? WriteSpeed { get; }
    }
}