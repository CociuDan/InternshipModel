using System;
using System.Text;
using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Monitor : Display
    {
        public Monitor() { }

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

        public new virtual int  ID { get; protected set; }
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }
    }
}