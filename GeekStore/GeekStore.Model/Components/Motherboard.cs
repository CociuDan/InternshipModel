using System;
using System.Text;

namespace GeekStore.Model.Components.Motherboards
{
    public class Motherboard : IItem
    {
        private readonly string _chipset;
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly int _pcieSlots;
        private readonly int _ramSlots;
        private readonly string _socket;

        public Motherboard(string chipset, string manufacturer, string model, int pcieSlots, int ramSlots, string socket)
        {
            try
            {
                if (string.IsNullOrEmpty(chipset) || string.IsNullOrWhiteSpace(chipset))
                    throw new ArgumentNullException(chipset);

                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                if (pcieSlots < 0)
                    throw new ArgumentException("Motherboard cannot have less than 0 PCI-E slots. Entered value: " + pcieSlots);

                if (ramSlots < 1)
                    throw new ArgumentException("Motherboard cannot have less than one RAM slot. Entered value: " + ramSlots);

                if (string.IsNullOrEmpty(socket) || string.IsNullOrWhiteSpace(socket))
                    throw new ArgumentNullException(socket);

                _chipset = chipset;
                _manufacturer = manufacturer;
                _model = model;
                _pcieSlots = pcieSlots;
                _ramSlots = ramSlots;
                _socket = socket;
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

        public string Chipset { get { return _chipset; } }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tChipset: {Chipset}");
                sb.AppendLine($"\tSocket: {Socket}");
                sb.AppendLine($"\tPCI-E Slots: {PCIESlots}");
                sb.AppendLine($"\tRAM Slots: {RAMSlots}");
                return sb.ToString();
            }
        }

        public string Manufacturer { get { return _manufacturer; } }
        public string Model { get { return _model; } }
        public int PCIESlots { get { return _pcieSlots; } }
        public int RAMSlots { get { return _ramSlots; } }
        public string Socket { get { return _socket; } }
    }
}