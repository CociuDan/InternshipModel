using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.PCs
{
    public class Desktop : Entity, IComputer
    {
        public Desktop() { }
        public virtual Case Case { get; set; }
        public virtual Cooler Cooler { get; set; }
        public virtual CPU CPU { get; set; }
        public virtual Disk Disk { get; set; }
        public virtual GPU GPU { get; set; }
        public virtual Motherboard Motherboard { get; set; }
        public virtual PowerUnit PowerUnit { get; set; }
        public virtual RAM RAM { get; set; }
    }
}