using System;

namespace GeekStore.Domain.Model.Components
{
    public enum DiskType { HDD, SSD}
    public class Disk : Product
    {
        public Disk() { }

        public Disk(int capacity, string manufacturer, string model, DiskType diskType, int rpm)
        {
            if (capacity <= 0) throw new ArgumentException($"Disk Capacity cannot be less or equal to 0. Entered value: {capacity}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (diskType != DiskType.HDD) throw new ArgumentException($"Invalid disk type, it has to be HDD in order to have RPM. Selected value: {diskType}");

            Capacity = capacity;
            Manufacturer = manufacturer;
            Model = model;
            RPM = rpm;
            Type = diskType.ToString();
        }

        public Disk(int capacity, string manufacturer, string model, DiskType diskType, int readSpeed, int writeSpeed)
        {
            if (capacity <= 0) throw new ArgumentException($"Disk Capacity cannot be less or equal to 0. Entered value: {capacity}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (diskType != DiskType.SSD) throw new ArgumentException($"Invalid disk type, it has to be SSD in order to have ReadSpeed & WriteSpeed. Selected value: {diskType}");

            Capacity = capacity;
            Manufacturer = manufacturer;
            Model = model;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            Type = diskType.ToString();
        }

        public virtual int Capacity { get; protected set; }
        public virtual int? RPM { get; protected set; }
        public virtual int? ReadSpeed { get; protected set; }
        public virtual int? WriteSpeed { get; protected set; }
        public virtual string Type { get; protected set; }

        public override string ToString()
        {
            return $"{Capacity} {GetType()}";
        }
    }
}