using System;
using System.Text;

namespace GeekStore.Model.Components.Disks
{
    public class HDD : Disk, IItem
    {
        public HDD(int capacity, string manufacturer, string model, int rpm) : base(capacity, manufacturer, model)
        {
            if (rpm <= 0)
                throw new ArgumentException("HDD RPM cannot be less or equal to 0");

            RPM = rpm;
        }

        public new string Description
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
        }

        public int RPM { get; }
    }
}