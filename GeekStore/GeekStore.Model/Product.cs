namespace GeekStore.Domain.Model
{
    public class Product : Entity
    {
        public Product() { }
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }
        public virtual decimal? Price { get; protected set; }
        public virtual int? AvailableQuantity { get; protected set; }
    }
}
