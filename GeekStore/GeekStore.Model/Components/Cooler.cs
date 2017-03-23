using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Components
{
    public class Cooler : IItem
    {
        public Cooler(string manufacturer, string model, string socket, int maxTdp)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(manufacturer);

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (string.IsNullOrEmpty(socket.Trim()))
                throw new ArgumentNullException(nameof(socket));

            if (maxTdp <= 0)
                throw new ArgumentException($"MaxTDP is less or equal to 0. Entered value: {maxTdp}");

            Manufacturer = manufacturer;
            MaxTDP = maxTdp;
            Model = model;
            Socket = socket;

        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tSocket: {Socket}");
                sb.AppendLine($"\tMax TDP: {MaxTDP}W");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public string Manufacturer { get; private set; }
        public int MaxTDP { get; private set; }
        public string Model { get; private set; }
        public string Socket { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Cooler")
            {
                ID = int.Parse(reader["ID"]);
                Manufacturer = reader["Manufacturer"];
                Model = reader["Model"];
                MaxTDP = int.Parse(reader["MaxTDP"]);
                Socket = reader["Socket"];
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("ID", ID.ToString());
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("MaxTDP", MaxTDP.ToString());
            writer.WriteAttributeString("Socket", Socket);
        }
    }
}