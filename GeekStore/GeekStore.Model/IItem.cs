using System.Xml.Serialization;

namespace GeekStore.Model
{
    public interface IItem : IXmlSerializable
    {
        string Description { get; }
        string Manufacturer { get; }
        string Model { get; }
    }
}
