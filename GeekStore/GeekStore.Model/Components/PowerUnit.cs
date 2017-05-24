namespace GeekStore.Domain.Model.Components
{
    public class PowerUnit : Product
    {
        public PowerUnit() { }

        public virtual int Output { get; protected set; }
    }
}