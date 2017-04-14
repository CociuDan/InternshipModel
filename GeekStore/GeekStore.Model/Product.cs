namespace GeekStore.Domain.Model
{
    public abstract class Product : Item
    {
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }
    }
}
