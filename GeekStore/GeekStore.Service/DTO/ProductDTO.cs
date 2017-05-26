namespace GeekStore.Service.DTO
{
    public abstract class ProductDTO : EntityDTO
    {
        public int? AvailableQuantity { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal? Price { get; set; }
    }
}