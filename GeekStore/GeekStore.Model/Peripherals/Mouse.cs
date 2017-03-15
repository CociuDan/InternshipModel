using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Mouse : IItem
    {
        public enum MouseType { Optical, Laser, Mechanical }
        private readonly int _dpi;
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly string _type;

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

                _dpi = dpi;
                _manufacturer = manufacturer;
                _model = model;
                _type = type.ToString();
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

        public int DPI { get { return _dpi; } }
        public string Manufacturer { get { return _manufacturer; } }
        public string Model { get { return _model; } }
        public string Type { get { return _type; } }
    }
}