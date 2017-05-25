namespace GeekStore.Domain.Model
{
    public class OrderItem : Entity
    {
        public OrderItem() { }
        public virtual Order Order { get; protected set; }
        public virtual Product Product { get; protected set; }
        public virtual int Quantity { get; protected set; }
        public virtual decimal Price { get; protected set; }
    }
}