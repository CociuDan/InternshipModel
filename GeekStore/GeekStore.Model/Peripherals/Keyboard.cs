using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Keyboard : IItem
    {
        public enum KeyboardType { Membrane, Mechanical }
        private readonly bool _backLight;
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly string _type;

        public Keyboard(bool backLight, string manufacturer, string model, KeyboardType type)
        {
            try
            {
                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                _backLight = backLight;
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
                sb.AppendLine($"\tBacklight: {BackLight}");
                sb.AppendLine($"\tType: {Type}");
                return sb.ToString();
            }
        }

        public bool BackLight { get { return _backLight; } }
        public string Manufacturer { get { return _manufacturer; } }
        public string Model { get { return _model; } }
        public string Type { get { return _type; } }
    }
}