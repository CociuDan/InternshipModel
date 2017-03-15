using System;
using System.Text;

namespace GeekStore.Model.Components.PowerUnits
{
    public class PowerUnit : IItem
    {
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly int _output;

        public PowerUnit(string manufacturer, string model, int output)
        {
            try
            {
                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                if (output <= 0)
                    throw new ArgumentException("Power Unit cannot have an output less or equal to 0W. Entered value: " + output.ToString());

                _manufacturer = manufacturer;
                _model = model;
                _output = output;
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
                sb.AppendLine($"\tOutput: {Output}W");
                return sb.ToString();
            }
        }

        public string Manufacturer { get { return _manufacturer; } }

        public string Model { get { return _model; } }

        public int Output { get { return _output; } }
    }
}