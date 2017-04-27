﻿using System;
using System.Text;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Monitor : Product
    {
        public Monitor() { }

        public Monitor(string aspectRatio, string manufacturer, int maxRefreshRate, string model, string resolution, decimal size)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (string.IsNullOrEmpty(aspectRatio.Trim())) throw new ArgumentNullException(nameof(aspectRatio));
            if (maxRefreshRate < 60) throw new ArgumentException($"Display Max Refresh Rate cannot be less than 60Hz. Entered value: {maxRefreshRate}");
            if (string.IsNullOrEmpty(resolution.Trim())) throw new ArgumentNullException(nameof(resolution));
            if (size <= 0) throw new ArgumentException($"Display size cannot be less or equal to 0. Entered value: {size}");

            Manufacturer = manufacturer;
            Model = model;
            AspectRatio = aspectRatio;
            MaxRefreshRate = maxRefreshRate;
            Resolution = resolution;
            Size = size;
        }

        public virtual string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tAspect Ratio: {AspectRatio}");
                sb.AppendLine($"\tMax Refresh Rate: {MaxRefreshRate}Hz");
                sb.AppendLine($"\tResolution: {Resolution}");
                return sb.ToString();
            }
            protected set
            {
                Description = value;
            }
        }

        public virtual string AspectRatio { get; protected set; }
        public virtual int MaxRefreshRate { get; protected set; }
        public virtual string Resolution { get; protected set; }
        public virtual decimal Size { get; protected set; }

        public override string ToString()
        {
            return $"{AspectRatio} {Resolution} @ {MaxRefreshRate}Hz";
        }
    }
}