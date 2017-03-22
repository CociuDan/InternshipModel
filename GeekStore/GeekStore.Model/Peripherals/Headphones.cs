using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Peripherals
{
    public class Headphones : IItem
    {
        public enum HeadphonesType { InEar, OnEar, OverEar }

        public Headphones(int impendance, string manufacturer, int maxVolume, string model, HeadphonesType type)
        {
            if (impendance <= 0)
                throw new ArgumentException($"Headphones Impendance cannot be less or equal to 0. Entered value: {impendance}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (maxVolume <= 0)
                throw new ArgumentException($"Speakers Max Volume cannot be less or equal than 0 Db. Entered value: {maxVolume}");

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Impendance = impendance;
            Manufacturer = manufacturer;
            MaxVolume = maxVolume;
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
                sb.AppendLine($"\tImpendance: {Impendance}Ω");
                sb.AppendLine($"\tMaxVolume: {MaxVolume}db");
                sb.AppendLine($"\tType: {Type}");
                return sb.ToString();
            }
        }

        public int Impendance { get; private set; }
        public string Manufacturer { get; private set; }
        public int MaxVolume { get; private set; }
        public string Model { get; private set; }
        public HeadphonesType Type { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Manufacturer = reader["Manufacturer"];
            Model = reader["Model"];
            Impendance = int.Parse(reader["Impendance"]);
            MaxVolume = int.Parse(reader["MaxVolume"]);
            Type = (HeadphonesType)Enum.Parse(typeof(HeadphonesType), reader["Type"]);
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("Impendance", Impendance.ToString());
            writer.WriteAttributeString("MaxVolume", MaxVolume.ToString());
            writer.WriteAttributeString("Type", Type.ToString());
        }
    }
}