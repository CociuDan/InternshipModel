using System.Xml.Serialization;

namespace GeekStore.Domain
{
    public enum ItemTypes { Case, Cooler, CPU, Display, GPU, HDD, Headphones, Laptop, Monitor, Motherboard, Mouse, PowerUnit, RAM, Speakers, SSD }
    public interface IItem
    {
        string Description { get; }
        int ID { get; }
        string Manufacturer { get; }
        string Model { get; }
    }
}
