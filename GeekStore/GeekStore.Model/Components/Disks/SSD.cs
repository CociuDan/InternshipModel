using System;
using System.Text;

namespace GeekStore.Model.Components.Disks
{
    public class SSD : Disk, IItem
    {
        public SSD(int capacity, string manufacturer, string model, int readSpeed, int writeSpeed) : base(capacity, manufacturer, model)
        {
            if (readSpeed <= 0)
                throw new ArgumentException($"SSDs Read Speed cannot be less or equal to 0. Entered value: {readSpeed}");

            if (writeSpeed <= 0)
                throw new ArgumentException($"SSDs Write Speed cannot be less or equal to 0. Entered value: {writeSpeed}");

            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }

        public new string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCapacity: {Capacity}GB");
                sb.AppendLine($"\tRead Speed: {ReadSpeed}Mbs");
                sb.AppendLine($"\tWrite Speed: {WriteSpeed}Mbs");
                return sb.ToString();
            }
        }

        public int ReadSpeed { get; }

        public int WriteSpeed { get; }
    }
}