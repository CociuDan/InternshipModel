namespace GeekStore.Domain.Model.Components
{
    public class Motherboard : Product
    {
        public Motherboard() { }
        public virtual string Chipset { get; protected set; }
        public virtual int PCIESlots { get; protected set; }
        public virtual int RAMSlots { get; protected set; }
        public virtual string Socket { get; protected set; }
    }
}