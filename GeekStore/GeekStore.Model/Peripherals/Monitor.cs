using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Monitor : Product
    {
        public Monitor() { }
        public virtual Display Display { get; protected set; }
    }
}