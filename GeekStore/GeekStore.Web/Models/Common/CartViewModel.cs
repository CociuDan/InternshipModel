namespace GeekStore.UI.Models.Common
{
    public class CartViewModel : EntityViewModel
    {
        public ProductViewModel Product { get; set; }
        public UserViewModel User { get; set; }
        public int? Quantity { get; set; }
    }
}