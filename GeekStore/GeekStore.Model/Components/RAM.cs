namespace GeekStore.Domain.Model.Components
{
    public class RAM : Product
    {
        public RAM() { }
        public virtual int Capacity { get; protected set; }
        public virtual int Frequency { get; protected set; }
        public virtual string Generation { get; protected set; }
    }
}