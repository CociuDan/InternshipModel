namespace GeekStore.UI.Models.Common
{
    public class OrderItemViewModel
    {
        public string ProductFullDescription { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}