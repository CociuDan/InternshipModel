namespace GeekStore.Service.Models
{
    public interface ILaptop : IProduct
    {
        ICPU CPU { get; }
        string Description { get; }
        IDisplay Display { get; }
        IDisk Disk { get; }
        IGPU GPU { get; }
        IMotherboard Motherboard { get; }
        IPowerUnit PowerUnit { get; }
        IRAM RAM { get; }
        int RAMQuantity { get; }
    }
}
