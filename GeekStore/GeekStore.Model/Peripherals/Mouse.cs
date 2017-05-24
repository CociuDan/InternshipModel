namespace GeekStore.Domain.Model.Peripherals
{
    public class Mouse : Product
    {
        public Mouse() { }
        public virtual int DPI { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}