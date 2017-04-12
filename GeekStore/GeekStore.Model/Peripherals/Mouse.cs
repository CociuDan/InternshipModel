using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Peripherals
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

        public int ID { get; private set; }
        public int DPI { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
    }
}