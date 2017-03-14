using System;

namespace GeekStore.Model.Components.Disks
{
    public abstract class Disk
    {
        private readonly int _capacity;
        private readonly int _readSpeed;
        private readonly int _writeSpeed;

        public Disk(int capacity, int readSpeed, int writeSpeed)
        {
            try
            {
                if (capacity <= 0)
                    throw new ArgumentException("Disk Capacity cannot be less or equal to 0. Entered value: " + capacity.ToString());

                if (readSpeed <= 0)
                    throw new ArgumentException("Disk Read Speed cannot be less or equal to 0. Entered value: " + readSpeed.ToString());

                if (writeSpeed <= 0)
                    throw new ArgumentException("Disk Write Speed cannot be less or equal to 0. Entered value: " + writeSpeed.ToString());

                _capacity = capacity;
                _readSpeed = readSpeed;
                _writeSpeed = writeSpeed;


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

        public int ReadSpeed { get { return _readSpeed; } }

        public int WriteSpeed { get { return _writeSpeed; } }
    }
}
