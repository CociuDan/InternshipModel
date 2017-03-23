using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using GeekStore.Model.Components;

namespace GeekStore.Model.Peripherals
{
    public class Monitor : Display, IItem
    {
        public Monitor(string aspectRatio, string manufacturer, int maxRefreshRate, string model, string resolution, double size)
                : base(aspectRatio, maxRefreshRate, resolution, size)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Manufacturer = manufacturer;
            Model = model;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tAspect Ratio: {AspectRatio}");
                sb.AppendLine($"\tMax Refresh Rate: {MaxRefreshRate}Hz");
                sb.AppendLine($"\tResolution: {Resolution}");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Manufacturer = reader["Manufacturer"];
            Model = reader["Model"];
            AspectRatio = reader["AspectRatio"];
            MaxRefreshRate = int.Parse(reader["MaxRefreshRate"]);
            Resolution = reader["Resolution"];
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("AspectRatio", AspectRatio);
            writer.WriteAttributeString("MaxRefreshRate", MaxRefreshRate.ToString());
            writer.WriteAttributeString("Resolution", Resolution);
        }
    }
}