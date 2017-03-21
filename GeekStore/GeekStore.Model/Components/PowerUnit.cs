using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class PowerUnit : IItem
    {
        public PowerUnit(string manufacturer, string model, int output)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (output <= 0)
                throw new ArgumentException($"Power Unit cannot have an output less or equal to 0W. Entered value: {output}");

            Manufacturer = manufacturer;
            Model = model;
            Output = output;
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

        public string Manufacturer { get; }

        public string Model { get; }

        public int Output { get; }
    }
}