namespace GeekStore.Domain.Model.Peripherals
{
    public class Headphones : Product
    {
        public Headphones() { }
        public virtual int Impendance { get; protected set; }
        public virtual int MaxVolume { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}