﻿using System;
using System.Text;
using GeekStore.Model.Components;

namespace GeekStore.Model.Peripherals
{
    public class Monitor : Display, IItem
    {
        private readonly string _manufacturer;
        private readonly string _model;

        public Monitor(string aspectRatio, string manufacturer, int maxRefreshRate, string model, string resolution, double size)
                : base(aspectRatio, maxRefreshRate, resolution, size)
        {
            try
            {
                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

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

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tResolution: {Resolution}");
                sb.AppendLine($"\tMax Refresh Rate: {MaxRefreshRate}Hz");
                sb.AppendLine($"\tAspect Ratio: {AspectRatio}");
                return sb.ToString();
            }
        }

        public string Manufacturer { get { return _manufacturer; } }

        public string Model { get { return _model; } }

    }
}