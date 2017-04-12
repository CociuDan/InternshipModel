using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Components
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

        public int ID { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Output { get; private set; }
    }
}