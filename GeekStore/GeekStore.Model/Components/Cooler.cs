using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Components
{
    public class Cooler : IItem
    {
        public Cooler(string manufacturer, string model, string socket)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(manufacturer);

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (string.IsNullOrEmpty(socket.Trim()))
                throw new ArgumentNullException(nameof(socket));

            Manufacturer = manufacturer;
            Model = model;
            Socket = socket;

        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tSocket: {Socket}");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string Socket { get; private set; }
    }
}