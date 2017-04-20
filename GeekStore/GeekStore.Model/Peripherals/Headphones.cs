using System;
using System.Text;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Headphones : Product
    {
        public enum HeadphonesType { InEar, OnEar, OverEar }

        public Headphones() { }

        public Headphones(int impendance, string manufacturer, int maxVolume, string model, HeadphonesType type)
        {
            if (impendance <= 0) throw new ArgumentException($"Headphones Impendance cannot be less or equal to 0. Entered value: {impendance}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (maxVolume <= 0) throw new ArgumentException($"Speakers Max Volume cannot be less or equal than 0 Db. Entered value: {maxVolume}");
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));

            Impendance = impendance;
            Manufacturer = manufacturer;
            MaxVolume = maxVolume;
            Model = model;
            Type = type.ToString();
        }

        public virtual string Description
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
            protected set
            {
                Description = value;
            }
        }

        public virtual int Impendance { get; protected set; }
        public virtual int MaxVolume { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}