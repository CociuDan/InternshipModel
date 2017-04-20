using System;
using System.Text;

namespace GeekStore.Domain.Model.Peripherals
{
    public class Keyboard : Product
    {
        public enum KeyboardType { Membrane, Mechanical }

        public Keyboard() { }

        public Keyboard(bool backLight, string manufacturer, string model, KeyboardType type)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));

            BackLight = backLight;
            Manufacturer = manufacturer;
            Model = model;
            Type = type.ToString();
        }

        public virtual string Description
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
            protected set
            {
                Description = value;
            }
        }

        public virtual bool BackLight { get; protected set; }
        public virtual string Type { get; protected set; }
    }
}