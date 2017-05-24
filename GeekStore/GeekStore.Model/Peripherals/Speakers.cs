namespace GeekStore.Domain.Model.Peripherals
{
    public class Speakers : Product
    {
        public Speakers() { }
        public virtual string Configuration { get; protected set; }
        public virtual int MaxVolume { get; protected set; }
    }
}