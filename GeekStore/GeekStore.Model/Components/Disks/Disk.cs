using System;

namespace GeekStore.Model.Components.Disks
{
    public abstract class Disk
    {
        public Disk(int capacity, string manufacturer, string model)
        {
            if (capacity <= 0)
                throw new ArgumentException($"Disk Capacity cannot be less or equal to 0. Entered value: {capacity}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Capacity = capacity;
            Manufacturer = manufacturer;
            Model = model;
        }

        public int Capacity { get; protected set; }

        public string Manufacturer { get; protected set; }

        public string Model { get; protected set; }

        public override string ToString()
        {
            return $"{Capacity} {GetType()}";
        }
    }
}