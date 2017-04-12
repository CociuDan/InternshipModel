using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Peripherals
{
    public class Keyboard : IItem
    {
        public enum KeyboardType { Membrane, Mechanical }

        public Keyboard(bool backLight, string manufacturer, string model, KeyboardType type)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            BackLight = backLight;
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
                sb.AppendLine($"\tBacklight: {BackLight}");
                sb.AppendLine($"\tType: {Type}");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public bool BackLight { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
    }
}