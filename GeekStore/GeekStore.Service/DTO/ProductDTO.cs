namespace GeekStore.Service.DTO
{
    public class ProductDTO : EntityDTO
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal? Price { get; set; }
        public int? AvailableQuantity { get; set; }
    }
}