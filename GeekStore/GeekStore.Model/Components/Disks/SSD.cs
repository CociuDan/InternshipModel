using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Components.Disks
{
    public class SSD : Disk, IItem
    {
        public SSD(int capacity, string manufacturer, string model, int readSpeed, int writeSpeed) : base(capacity, manufacturer, model)
        {
            if (readSpeed <= 0)
                throw new ArgumentException($"SSDs Read Speed cannot be less or equal to 0. Entered value: {readSpeed}");

            if (writeSpeed <= 0)
                throw new ArgumentException($"SSDs Write Speed cannot be less or equal to 0. Entered value: {writeSpeed}");

            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }

        public SSD Deserialize(XmlReader reader)
        {
            ReadXml(reader);
            return this;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCapacity: {Capacity}GB");
                sb.AppendLine($"\tRead Speed: {ReadSpeed}Mbs");
                sb.AppendLine($"\tWrite Speed: {WriteSpeed}Mbs");
                return sb.ToString();
            }
        }

        public int ReadSpeed { get; private set; }

        public int WriteSpeed { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "SSD")
            {                
                Manufacturer = reader["Manufacturer"];
                Model = reader["Model"];
                Capacity = int.Parse(reader["Capacity"]);
                ReadSpeed = int.Parse(reader["ReadSpeed"]);
                WriteSpeed = int.Parse(reader["WriteSpeed"]);
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("Capacity", Capacity.ToString());
            writer.WriteAttributeString("ReadSpeed", ReadSpeed.ToString());
            writer.WriteAttributeString("WriteSpeed", WriteSpeed.ToString());
        }
    }
}