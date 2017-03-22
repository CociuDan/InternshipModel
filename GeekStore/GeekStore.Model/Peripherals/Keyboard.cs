using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Peripherals
{
    public class Keyboard : IItem
    {
        public enum KeyboardType { Membrane, Mechanical }

        public Keyboard(bool backLight, string manufacturer, string model, KeyboardType type)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            BackLight = backLight;
            Manufacturer = manufacturer;
            Model = model;
            Type = type;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tBacklight: {BackLight}");
                sb.AppendLine($"\tType: {Type}");
                return sb.ToString();
            }
        }

        public bool BackLight { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public KeyboardType Type { get; private set; }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            Manufacturer = reader["Manufacturer"];
            Model = reader["Model"];
            BackLight = bool.Parse(reader["BackLight"]);
            Type = (KeyboardType)Enum.Parse(typeof(KeyboardType), reader["Type"]);
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("BackLight", BackLight.ToString());
            writer.WriteAttributeString("Type", Type.ToString());
        }
    }
}