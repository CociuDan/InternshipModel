namespace GeekStore.Service.DTO
{
    public class CartDTO : EntityDTO
    {
        public ProductDTO Product { get; set; }
        public int? Quantity { get; set; }
        public UserDTO User { get; set; }
    }
}