using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Components.Disks
{
    public class HDD : Disk, IItem
    {
        public HDD(int capacity, string manufacturer, string model, int rpm) : base(capacity, manufacturer, model)
        {
            if (rpm <= 0)
                throw new ArgumentException("HDD RPM cannot be less or equal to 0");

            RPM = rpm;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCapacity: {Capacity}GB");
                sb.AppendLine($"\tRPM: {RPM}");
                return sb.ToString();
            }
        }

        public int RPM { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "HDD")
            {
                Manufacturer = reader["Manufacturer"];
                Model = reader["Model"];
                Capacity = int.Parse(reader["Capacity"]);
                RPM = int.Parse(reader["RPM"]);
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("Capacity", Capacity.ToString());
            writer.WriteAttributeString("RPM", RPM.ToString());
        }
    }
}