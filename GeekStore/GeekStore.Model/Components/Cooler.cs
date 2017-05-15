using System;

namespace GeekStore.Domain.Model.Components
{
    public class Cooler : Product
    {
        public Cooler() { }

        public Cooler(string manufacturer, string model, string socket)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(manufacturer);
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (string.IsNullOrEmpty(socket.Trim())) throw new ArgumentNullException(nameof(socket));

            Manufacturer = manufacturer;
            Model = model;
            Socket = socket;
        }

        public virtual string Socket { get; protected set; }
    }
}