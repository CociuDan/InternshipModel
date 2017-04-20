using System;
using System.Text;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Speakers : Product
    {
        public Speakers() { }

        public Speakers(string configuration, string manufacturer, int maxVolume, string model)
        {
            if (configuration != "1.0" && configuration != "2.0" && configuration != "2.1" && configuration != "3.1" && configuration != "4.0"
                && configuration != "4.1" && configuration != "5.1" && configuration != "6.1" && configuration != "7.1")
                throw new ArgumentException($"Speakers unkown configuration. Entered value: {configuration}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (maxVolume <= 0) throw new ArgumentException($"Speakers Max Volume cannot be less or equal than 0 Db. Entered value: {maxVolume}");
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));

            Configuration = configuration;
            Manufacturer = manufacturer;
            MaxVolume = maxVolume;
            Model = model;
        }

        public virtual string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tConfiguration: {Configuration}");
                sb.AppendLine($"\tMax Volume: {MaxVolume}Db");
                return sb.ToString();
            }
            protected set
            {
                Description = value;
            }
        }

        public virtual string Configuration { get; protected set; }
        public virtual int MaxVolume { get; protected set; }
    }
}