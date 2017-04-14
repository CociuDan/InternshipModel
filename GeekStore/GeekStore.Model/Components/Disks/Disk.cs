using System;

namespace GeekStore.Domain.Model.Components.Disks
{
    public abstract class Disk : Product
    {
        public Disk() { }

        public Disk(int capacity, string manufacturer, string model)
        {
            if (capacity <= 0) throw new ArgumentException($"Disk Capacity cannot be less or equal to 0. Entered value: {capacity}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));

            Capacity = capacity;
            Manufacturer = manufacturer;
            Model = model;
        }

        public virtual int Capacity { get; protected set; }
        public override string ToString()
        {
            return $"{Capacity} {GetType()}";
        }
    }
}