namespace GeekStore.Domain.Model
{
    public abstract class Product : Entity
    {
        public Product() { }
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }
    }
}
