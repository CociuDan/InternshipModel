namespace GeekStore.Domain.Model.Peripherals
{
    public class Keyboard : Product
    {
        public Keyboard() { }
        public virtual bool BackLight { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}