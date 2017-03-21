using System;
using System.Text;

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
            Type = type.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tType: {Type}");
                sb.AppendLine($"\tImpendance: {Impendance}Ω");
                return sb.ToString();
            }
        }

        public int Impendance { get; }
        public string Manufacturer { get; }
        public int MaxVolume { get; }
        public string Model { get; }
        public string Type { get; }
    }
}