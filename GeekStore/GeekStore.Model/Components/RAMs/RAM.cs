using System;

namespace GeekStore.Model.Components.RAMs
{
    public abstract class RAM
    {
        public enum RAMGeneration { DDR, DDR2, DDR3, DDR4 }
        private readonly int _capacity;
        private readonly int _frequency;
        private readonly string _generation;

        public RAM(int capacity, int frequency, RAMGeneration ramGeneration)
        {
            if (capacity != 512 && capacity != 1024 && capacity != 2048 && capacity != 4096 && capacity != 6144 && capacity != 8192 &&
                capacity != 10240 && capacity != 16384 && capacity != 32768 && capacity != 65536 && capacity != 131072)
                throw new ArgumentException("RAM Capacity cannot be less than 512MB and higher than 128GB(131072). Entered value: " + capacity.ToString());

            if (frequency <= 0)
                throw new ArgumentException("RAM Frequency cannot be less or equal to 0. Entered value: " + frequency.ToString());

            _capacity = capacity;
            _frequency = frequency;
            _generation = ramGeneration.ToString();
        }

        public int Capacity { get { return _capacity; } }

        public int Frequency { get { return _frequency; } }

        public string Generation { get { return _generation; } }
    }
}
