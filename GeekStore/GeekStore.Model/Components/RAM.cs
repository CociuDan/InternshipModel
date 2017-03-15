using System;
using System.Text;

namespace GeekStore.Model.Components.RAMs
{
    public class RAM : IItem
    {
        public enum RAMGeneration { DDR, DDR2, DDR3, DDR4 }
        private readonly int _capacity;
        private readonly int _frequency;
        private readonly string _generation;
        private readonly string _manufacturer;
        private readonly string _model;

        public RAM(int capacity, int frequency, RAMGeneration ramGeneration, string manufacturer, string model)
        {
            if (capacity != 512 && capacity != 1024 && capacity != 2048 && capacity != 4096 && capacity != 6144 && capacity != 8192 &&
                capacity != 10240 && capacity != 16384 && capacity != 32768 && capacity != 65536 && capacity != 131072)
                throw new ArgumentException("RAM Capacity cannot be less than 512MB and higher than 128GB(131072MB). Entered value: " + capacity.ToString());

            if (frequency <= 0)
                throw new ArgumentException("RAM Frequency cannot be less or equal to 0. Entered value: " + frequency.ToString());

            if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(manufacturer);

            if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(model);

            _capacity = capacity;
            _frequency = frequency;
            _generation = ramGeneration.ToString();
            _manufacturer = manufacturer;
            _model = model;
        }
        public string Description
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

        public int Capacity { get { return _capacity; } }
        public int Frequency { get { return _frequency; } }
        public string Generation { get { return _generation; } }
        public string Manufacturer { get { return _manufacturer; } }
        public string Model { get { return _model; } }
    }
}