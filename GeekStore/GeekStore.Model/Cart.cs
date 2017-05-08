namespace GeekStore.Domain.Model
{
    public class Cart : Entity
    {
        public Cart() { }
        public virtual User User { get; protected set; }
        public virtual WarehouseProduct Product { get; protected set; }
        public virtual int Quantity { get; protected set; }
    }
}
