using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class Cooler : IItem
    {
        public Cooler(string manufacturer, string model, string socket, int maxTdp)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(manufacturer);

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (string.IsNullOrEmpty(socket.Trim()))
                throw new ArgumentNullException(nameof(socket));

            if (maxTdp <= 0)
                throw new ArgumentException($"MaxTDP is less or equal to 0. Entered value: {maxTdp}");

            Manufacturer = manufacturer;
            MaxTDP = maxTdp;
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
                sb.AppendLine($"\tMax TDP: {MaxTDP}W");
                return sb.ToString();
            }
        }

        public string Manufacturer { get; }
        public string Model { get; }
        public string Socket { get; }
        public int MaxTDP { get; }
    }
}