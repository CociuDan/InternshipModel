﻿using System;
using System.Text;

namespace GeekStore.Domain.Model.Components
{
    public class RAM : Product
    {
        public enum RAMGeneration { DDR, DDR2, DDR3, DDR4 }

        public RAM() { }

        public RAM(int capacity, int frequency, RAMGeneration ramGeneration, string manufacturer, string model)
        {
            if (capacity <= 0) throw new ArgumentException($"RAM Capacity cannot be less or equal to 0. Entered value: {capacity}");
            if (frequency <= 0) throw new ArgumentException($"RAM Frequency cannot be less or equal to 0. Entered value: {frequency}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));

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

        public virtual int Capacity { get; protected set; }
        public virtual int Frequency { get; protected set; }
        public virtual string Generation { get; protected set; }

        public override string ToString()
        {
            return $"{Capacity}MB {Generation} {Frequency}Mhz";
        }
    }
}