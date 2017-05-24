namespace GeekStore.Domain.Model.Components
{
    public class Display : Entity
    {
        public Display() { }

        public virtual string AspectRatio { get; protected set; }
        public virtual int MaxRefreshRate { get; protected set; }
        public virtual string Resolution { get; protected set; }
        public virtual decimal Size { get; protected set; }
    }
}