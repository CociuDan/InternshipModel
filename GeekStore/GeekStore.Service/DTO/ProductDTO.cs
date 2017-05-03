namespace GeekStore.Service.DTO
{
    public abstract class ProductDTO : EntityDTO
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}