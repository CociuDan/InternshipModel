using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Peripherals
{
    public class Speakers : IItem
    {
        public Speakers(string configuration, string manufacturer, int maxVolume, string model)
        {
            if (configuration != "1.0" && configuration != "2.0" && configuration != "2.1" && configuration != "3.1" && configuration != "4.0"
                && configuration != "4.1" && configuration != "5.1" && configuration != "6.1" && configuration != "7.1")
                throw new ArgumentException($"Speakers unkown configuration. Entered value: {configuration}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (maxVolume <= 0)
                throw new ArgumentException($"Speakers Max Volume cannot be less or equal than 0 Db. Entered value: {maxVolume}");

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Configuration = configuration;
            Manufacturer = manufacturer;
            MaxVolume = maxVolume;
            Model = model;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tConfiguration: {Configuration}");
                sb.AppendLine($"\tMax Volume: {MaxVolume}Db");
                return sb.ToString();
            }
        }

        public string Configuration { get; private set; }
        public string Manufacturer { get; private set; }
        public int MaxVolume { get; private set; }
        public string Model { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Manufacturer = reader["Manufacturer"];
            Model = reader["Model"];
            Configuration = reader["Configuration"];
            MaxVolume = int.Parse(reader["MaxVolume"]);
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("Configuration", Configuration);
            writer.WriteAttributeString("MaxVolume", MaxVolume.ToString());
        }
    }
}