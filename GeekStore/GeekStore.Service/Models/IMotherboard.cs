namespace GeekStore.Service.Models
{
    public interface IMotherboard : IProduct
    {
        string Chipset { get; }
        string Description { get; }
        int PCIESlots { get; }
        int RAMSlots { get; }
        string Socket { get; }
    }
}
