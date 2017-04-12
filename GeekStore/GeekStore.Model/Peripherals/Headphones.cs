using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Peripherals
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
            Type = type.ToString();
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

        public int ID { get; private set; }
        public int Impendance { get; private set; }
        public string Manufacturer { get; private set; }
        public int MaxVolume { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
    }
}