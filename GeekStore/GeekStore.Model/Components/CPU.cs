namespace GeekStore.Domain.Model.Components
{
    public class CPU : Product
    {
        public CPU() { }
        public virtual decimal BaseFrequency { get; protected set; }
        public virtual decimal BoostFrequency { get; protected set; }
        public virtual int Cores { get; protected set; }
        public virtual string Socket { get; protected set; }
        public virtual int TDP { get; protected set; }
        public virtual int Threads { get; protected set; }
    }
}