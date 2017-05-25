namespace GeekStore.Service.DTO
{
    public class WarehouseProductDTO : EntityDTO
    {
        public ProductDTO Product { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }
    }
}