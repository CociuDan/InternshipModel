using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class Cooler : IItem
    {
        public Cooler(string manufacturer, string model, double price, string socket, int maxTdp)
        {
            try
            {
                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                if (price <= 0)
                    throw new ArgumentException("Price cannot be less or equal to 0. Entered value: " + price.ToString());

                if (string.IsNullOrEmpty(socket) || string.IsNullOrWhiteSpace(socket))
                    throw new ArgumentNullException(socket);

                if (maxTdp <= 0)
                    throw new ArgumentException("MaxTDP is less or equal to 0. Entered value: " + maxTdp.ToString());

                Manufacturer = manufacturer;
                MaxTDP = maxTdp;
                Model = model;
                Socket = socket;
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