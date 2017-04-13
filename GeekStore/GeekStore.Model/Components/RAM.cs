using System;
using System.Text;

namespace GeekStore.Domain.Model.Components
{
    public class RAM : IItem
    {
        public enum RAMGeneration { DDR, DDR2, DDR3, DDR4 }

        public RAM() { }

        public RAM(int capacity, int frequency, RAMGeneration ramGeneration, string manufacturer, string model)
        {
            if (capacity != 512 && capacity != 1024 && capacity != 2048 && capacity != 4096 && capacity != 6144 && capacity != 8192 &&
                capacity != 10240 && capacity != 16384 && capacity != 32768 && capacity != 65536 && capacity != 131072)
                throw new ArgumentException($"RAM Capacity cannot be less than 512MB and higher than 128GB(131072MB). Entered value: {capacity}");

            if (frequency <= 0)
                throw new ArgumentException($"RAM Frequency cannot be less or equal to 0. Entered value: {frequency}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Capacity = capacity;
            Frequency = frequency;
            Generation = ramGeneration.ToString();
            Manufacturer = manufacturer;
            Model = model;
        }

        public virtual string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tGeneration: {Generation}");
                sb.AppendLine($"\tCapacity: {Capacity}MB");
                sb.AppendLine($"\tFrequency: {Frequency}");
                return sb.ToString();
            }
        }

        public virtual int ID { get; protected set; }
        public virtual int Capacity { get; protected set; }
        public virtual int Frequency { get; protected set; }
        public virtual string Generation { get; protected set; }
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }

        public override string ToString()
        {
            return $"{Capacity}MB {Generation} {Frequency}Mhz";
        }
    }
}