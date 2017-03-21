using System;
using System.Text;
using GeekStore.Model.Components;

namespace GeekStore.Model.Peripherals
{
    public class Monitor : Display, IItem
    {
        public Monitor(string aspectRatio, string manufacturer, int maxRefreshRate, string model, string resolution, double size)
                : base(aspectRatio, maxRefreshRate, resolution, size)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            Manufacturer = manufacturer;
            Model = model;
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

        public string Manufacturer { get; }

        public string Model { get; }
    }
}