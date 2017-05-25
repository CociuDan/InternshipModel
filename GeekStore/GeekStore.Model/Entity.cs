namespace GeekStore.Domain.Model
{
    public abstract class Entity
    {
        public Entity() { }
        public virtual int ID { get; protected set; }
    }
}