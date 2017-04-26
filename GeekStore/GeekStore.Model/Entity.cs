namespace GeekStore.Domain
{
    public enum ItemTypes { Case, Cooler, CPU, Disk, Display, GPU, Headphones, Laptop, Monitor, Motherboard, Mouse, PowerUnit, RAM, Speakers }
    public abstract class Entity
    {
        public Entity() { }
        public virtual int ID { get; protected set; }
    }
}