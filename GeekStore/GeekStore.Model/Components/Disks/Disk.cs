using System;

namespace GeekStore.Model.Components.Disks
{
    public abstract class Disk
    {
        private readonly int _capacity;
        private readonly string _manufacturer;
        private readonly string _model;


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

                _capacity = capacity;
                _manufacturer = manufacturer;
                _model = model;
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

        public int Capacity { get { return _capacity; } }

        public string Description { get; }

        public string Manufacturer { get { return _manufacturer; } }

        public string Model { get { return _model; } }
    }
}