namespace GeekStore.Domain.Model.Components
{
    public class Cooler : Product
    {
        public Cooler() { }

        public virtual string Socket { get; protected set; }
    }
}