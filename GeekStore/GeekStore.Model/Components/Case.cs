namespace GeekStore.Domain.Model.Components
{
    public class Case : Product
    {
        public Case() { }
        public virtual string FormFactor { get; protected set; }
    }
}