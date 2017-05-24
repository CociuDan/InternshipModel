namespace GeekStore.Domain.Model.Components
{
    public class Disk : Product
    {
        public Disk() { }
        public virtual int Capacity { get; protected set; }
        public virtual int? RPM { get; protected set; }
        public virtual int? ReadSpeed { get; protected set; }
        public virtual int? WriteSpeed { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}