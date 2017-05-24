namespace GeekStore.Domain.Model.Components
{
    public class GPU : Product
    {
        public GPU() { }
        public virtual string Architecture { get; protected set; }
        public virtual int InterfaceWidth { get; protected set; }
        public virtual string MemoryInterface { get; protected set; }
        public virtual int VRAM { get; protected set; }
    }
}