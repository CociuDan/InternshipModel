namespace GeekStore.Domain.Model
{
    public class OrderItem : Entity
    {
        public OrderItem() { }
        public virtual string ProductFullDescription { get; protected set; }
        public virtual string ProductType { get; protected set; }
        public virtual int Quantity { get; protected set; }
        public virtual decimal Price { get; protected set; }
    }
}