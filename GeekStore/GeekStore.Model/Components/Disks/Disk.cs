using System;

namespace GeekStore.Model.Components.Disks
{
    public abstract class Disk
    {
        public Disk(int capacity, string manufacturer, string model)
        {
            try
            {
                if (capacity <= 0)
                    throw new ArgumentException("Disk Capacity cannot be less or equal to 0. Entered value: " + capacity.ToString());

                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                Capacity = capacity;
                Manufacturer = manufacturer;
                Model = model;
            }
            catch (ArgumentNullException exception)
            {
                throw exception;
            }
            catch (ArgumentException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public int Capacity { get; }

        public string Description { get; }

        public string Manufacturer { get; }

        public string Model { get; }
    }
}