using System;
using System.Text;

namespace GeekStore.Domain.Model.Components.Disks
{
    public class HDD : Disk
    {
        public HDD() { }

        public HDD(int capacity, string manufacturer, string model, int rpm) : base(capacity, manufacturer, model)
        {
            if (rpm <= 0) throw new ArgumentException("HDD RPM cannot be less or equal to 0");

            RPM = rpm;
        }

        public virtual string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCapacity: {Capacity}GB");
                sb.AppendLine($"\tRPM: {RPM}");
                return sb.ToString();
            }
            protected set
            {
                Description = value;
            }
        }

        public virtual int ID { get; protected set; }
        public virtual int RPM { get; protected set; }
    }
}