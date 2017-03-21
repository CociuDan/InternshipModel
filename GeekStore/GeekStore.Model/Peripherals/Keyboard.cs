using System;
using System.Text;

namespace GeekStore.Model.Peripherals
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

        public bool BackLight { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }
    }
}