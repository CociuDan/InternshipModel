using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.PCs
{
    public class Laptop : Product, IComputer
    {
        public Laptop() { }

        public virtual CPU CPU { get; protected set; }
        public virtual Display Display { get; protected set; }
        public virtual Disk Disk { get; protected set; }
        public virtual GPU GPU { get; protected set; }
        public virtual Motherboard Motherboard { get; protected set; }
        public virtual PowerUnit PowerUnit { get; protected set; }
        public virtual RAM RAM { get; protected set; }
    }
}