using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Mouse : IItem
    {
        public enum MouseType { Optical, Laser, Mechanical }

        public Mouse(int dpi, string manufacturer, string model, MouseType type)
        {
            if (dpi <= 0)
                throw new ArgumentException($"Mouse cannot have a DPI less or equal to 0. Entered value: {dpi}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            DPI = dpi;
            Manufacturer = manufacturer;
            Model = model;
            Type = type.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tDPI: {DPI}");
                sb.AppendLine($"\tType: {Type}");
                return sb.ToString();
            }
        }

        public int DPI { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }
    }
}