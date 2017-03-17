using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Mouse : IItem
    {
        public enum MouseType { Optical, Laser, Mechanical }

        public Mouse(int dpi, string manufacturer, string model, MouseType type)
        {
            try
            {
                if (dpi <= 0)
                    throw new ArgumentException("Mouse cannot have a DPI less or equal to 0. Entered value: " + dpi.ToString());

                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                DPI = dpi;
                Manufacturer = manufacturer;
                Model = model;
                Type = type.ToString();
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